﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Diagnostics;

namespace B16_Ex01_Roi_302882527_Iris_30580715
{



    public partial class Facebook : Form
    {
        public Facebook()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        User m_LoggedInUser;
        GMapMarker lastMarker;
        String accessToken;
        double currMaplat;
        double currMapLng;

        private const int k_SharedEventsCheckedListIndex = 0;
        private const int k_SharedCheckinsCheckedListIndex = 1;
        private const int k_SharedLikedPagesCheckedListIndex = 2;
        private const int k_LikedMyPhotosCheckedListIndex = 3;
        private const int k_CommentedOnPhotosCheckedListIndex = 4;
        private const int k_NumOfParametersOptionsToRate = 5;
        private const string k_FriendNotFoundUrl = "http://blog.symbyoz.com/wp-content/uploads/2012/04/friend_not_found.jpg";


        private void loginAndInit()
        {
            // Acess Token Roi: "CAAWkQ6soPp0BAPQ1QsZBV3UguaR1WTrT2mSXqvDRGhKJGIBuZBcsNbZCapkQCQxpQVZBZArdDvTNuA8ZCIb4Vbj8PcUhiaQym4weRsUyuwOwfgiuSTYYPpFl9ygBNxuhESppLv8MLM3xgzDcRMAXOnVufuIBespvuB1rIb2Vdkhp6kqeiawaTG6yVtkZCtQDy1KkFlALAn53AZDZD"
            // Acess Token Iris: "CAAWkQ6soPp0BADC8XS19wOmrlTqzgRHtrFWYyWDRv5GAmtW9jtclEZB5Tvp1FVJe7a37WrD44PnExe2rZAqPRQtwb4c8SYyMgjh4WZBlOEfN5p1DkabKFtl0oZASvmlvZCYJbjgTGoQvP9GHj64QIb6EdOgpk9ZAkRgBTy3vyASjuFgkQRnllMVaZAYZAkU1ip0OlJVaWTcbzwZDZD"
             accessToken = "CAAWkQ6soPp0BADC8XS19wOmrlTqzgRHtrFWYyWDRv5GAmtW9jtclEZB5Tvp1FVJe7a37WrD44PnExe2rZAqPRQtwb4c8SYyMgjh4WZBlOEfN5p1DkabKFtl0oZASvmlvZCYJbjgTGoQvP9GHj64QIb6EdOgpk9ZAkRgBTy3vyASjuFgkQRnllMVaZAYZAkU1ip0OlJVaWTcbzwZDZD";
            LoginResult result = FacebookService.Connect(accessToken);

            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            // You can then save the result.AccessToken for future auto-connect to this user:
            //LoginResult result = FacebookService.Login("1587985424858781", 
            //    "public_profile",
            //    "user_education_history",
            //    "user_birthday",
            //    "user_actions.video",
            //    "user_actions.news",
            //    "user_actions.music",
            //    "user_actions.fitness",
            //    "user_actions.books",
            //    "user_about_me",
            //    "user_friends",
            //    "publish_actions",
            //    "user_events",
            //    "user_games_activity",
            //    //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
            //    "user_hometown",
            //    "user_likes",
            //    "user_location",
            //    "user_managed_groups",
            //    "user_photos",
            //    "user_posts",
            //    "user_relationships",
            //    "user_relationship_details",
            //    "user_religion_politics",

            //    //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
            //    "user_tagged_places",
            //    "user_videos",
            //    "user_website",
            //    "user_work_history",
            //    "read_custom_friendlists",

            //    // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
            //    "read_page_mailboxes",
            //    // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
            //    // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
            //    "manage_pages",
            //    "publish_pages",
            //    "publish_actions",

            //    "rsvp_event"
            //    );
            // These are NOT the complete list of permissions. Other permissions for example:
            // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
            // The documentation regarding facebook login and permissions can be found here: 
            // https://developers.facebook.com/docs/facebook-login/permissions#reference

            
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                textBoxPleaseLogin.Visible = false;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
            tabControl1.Enabled = true;
        }

        private void showYourFacebookMarkersOnMap()
        {
            showMarkersOnMap(m_LoggedInUser, GMarkerGoogleType.red);

            // Get most visited place
            if (m_LoggedInUser.Checkins.Count > 0)
            {
                Checkin mostVisitedPlace = m_LoggedInUser.Checkins.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
                richTextBox1.Text = "Most Visited Place: " + mostVisitedPlace.Place.Name;
            }
        }

        private void showMarkersOnMap(User currUser, GMarkerGoogleType color)
        {
            double dLongitude;
            double dLatitude;

            GMapOverlay markersOverlay = new GMapOverlay("markers");

            foreach (Checkin item in currUser.Checkins)
            {
                if ((item.Place.Location != null) && 
                    (item.CreatedTime.Value < dateTimePickerTo.Value) &&
                    (item.CreatedTime.Value > dateTimePickerFrom.Value))
                {
                    dLongitude = Convert.ToDouble(item.Place.Location.Longitude);
                    dLatitude = Convert.ToDouble(item.Place.Location.Latitude);

                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(dLatitude, dLongitude), color);
                    marker.ToolTipText = item.Place.Name + " " + item.Place.Location.City;
                    gmap.Overlays.Add(markersOverlay);
                    markersOverlay.Markers.Add(marker);
                }
            }
        }

        private void showFriendMarkersOnMap(User userFriend)
        {
            showMarkersOnMap(userFriend, GMarkerGoogleType.green);
        }

        private void checkButtonMinusZoomEnabled()
        {
            buttonMinusZoom.Enabled = (gmap.Zoom > gmap.MinZoom);
        }

        private void checkButtonPlusZoomEnabled()
        {
            buttonPlusZoom.Enabled = (gmap.Zoom < gmap.MaxZoom);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
             rateFriends();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            // Initialize map:
            //
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.DragButton = System.Windows.Forms.MouseButtons.Left;

            checkButtonMinusZoomEnabled();
            checkButtonPlusZoomEnabled();
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            double? lng = item.Position.Lng;
            double? lat = item.Position.Lat;

            // Do a google search on the place
            webBrowserGooglecheckin.Navigate(string.Format("https://www.google.co.il/search?q={0}", item.ToolTipText.Replace(" ", "+")));
            
            // Details about the checkin
            Predicate<Checkin> checkinFinder = (Checkin c) => { return (c.Place.Location != null) && (c.Place.Location.Latitude == lat) && (c.Place.Location.Longitude == lng); };
            Checkin currCheckin = m_LoggedInUser.Checkins.Find(checkinFinder) != null ? m_LoggedInUser.Checkins.Find(checkinFinder) : ((User)listBoxFriends.SelectedItem).Checkins.Find(checkinFinder);
            

            String names = "";

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.Checkins.Find(checkinFinder) != null)
                {
                    names += (friend.Name + " ");
                }
            }

            richTextBoxCheckinDetails.Text = "Place: " + currCheckin.Place.Name + "\n" +
                                             "Time Visited: " + currCheckin.UpdateTime.ToString() + "\n" +
                                             "Friends of " + m_LoggedInUser.Name + " who were there also: " + names + "\n";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void buttonPlusZoom_Click(object sender, EventArgs e)
        {
            gmap.Zoom++;

            checkButtonPlusZoomEnabled();
            checkButtonMinusZoomEnabled();
        }

        private void buttonMinusZoom_Click(object sender, EventArgs e)
        {
            gmap.Zoom--;

            checkButtonMinusZoomEnabled();
            checkButtonPlusZoomEnabled();
        }


        private void gmap_OnMarkerLeave(GMapMarker item)
        {
            // set remove chekin as false
            contextMenuStripMap.Items[0].Enabled = false; 
        }

        private void gmap_OnMarkerEnter(GMapMarker item)
        {
            // set remove chekin as true
            contextMenuStripMap.Items[0].Enabled = true; 
        }


        //private void map_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //    {
        //        double lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
        //        double lng = map.FromLocalToLatLng(e.X, e.Y).Lng;
        //    }

        //    List<Placemark> plc = null;
        //    var st = GMapProviders.GoogleMap.GetPlacemarks(map.FromLocalToLatLng(e.X, e.Y), out plc);
        //    if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
        //    {
        //        foreach (var pl in plc)
        //        {
        //            if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
        //            {
        //                Debug.WriteLine("Accuracy: " + pl.Accuracy + ", " + pl.Address + ", PostalCodeNumber: " + pl.PostalCodeNumber);
        //            }
        //        }
        //    }
        //}
              
         private void rateFriends()
        {
             Dictionary<string, int> topFriends = new Dictionary<string, int>();

             hideTopFriends();              
             if(m_LoggedInUser == null)
             {
                  textBoxPleaseLogin.Visible = true;
             }
             else 
             {
                  if (checkedListBoxParametersToRateFriends.CheckedItems.Count == 0)
                  {
                       textBoxNoRateParametersSelected.Visible = true;
                  }
                  else
                  {
                       textBoxNoRateParametersSelected.Visible = false;
                       if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_SharedEventsCheckedListIndex) == true)
                       {
                            updateTopFriendsAccordingToSharedEvents(topFriends);   
                       }
                       if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_SharedCheckinsCheckedListIndex) == true)
                       {
                            updateTopFriendsAccordingToSharedCheckins(topFriends);
                       }
                       if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_SharedLikedPagesCheckedListIndex) == true)
                       {
                            updateTopFriendsAccordingToSharedPages(topFriends);
                       }
                       if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_LikedMyPhotosCheckedListIndex) == true)
                       {
                            updateTopFriendsAccordingToLikesOnPhotos(topFriends);
                       }
                       if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_CommentedOnPhotosCheckedListIndex) == true)
                       {
                            updateTopFriendsAccordingToCommentsOnPhotos(topFriends);
                       }

                       var result = topFriends.OrderByDescending(pair => pair.Value);
                       List<KeyValuePair<string, int>> topFriendsList = result.ToList();
                       showTopFriends(topFriendsList);
               }                   
             }
        }

         
         private void hideTopFriends()
         {
              textBoxFriendNo1.Visible = false;
              textBoxFriendNo2.Visible = false;
              textBoxFriendNo3.Visible = false;
              textBoxFriendNo4.Visible = false;
              pictureBoxFriendNo1.Visible = false;
              pictureBoxFriendNo2.Visible = false;
              pictureBoxFriendNo3.Visible = false;
              pictureBoxFriendNo4.Visible = false;
         }


        private void showTopFriends(List<KeyValuePair<string, int>> list)
        {        
               switch(list.Count)
               {
                    case 0:
                         pictureBoxFriendNo1.LoadAsync(k_FriendNotFoundUrl);
                         pictureBoxFriendNo2.LoadAsync(k_FriendNotFoundUrl);
                         pictureBoxFriendNo3.LoadAsync(k_FriendNotFoundUrl);
                         pictureBoxFriendNo4.LoadAsync(k_FriendNotFoundUrl);
                         break;
                    case 1:
                         pictureBoxFriendNo1.LoadAsync(getUserById(list.ElementAt(0).Key).PictureLargeURL);
                         pictureBoxFriendNo2.LoadAsync(k_FriendNotFoundUrl);
                         pictureBoxFriendNo3.LoadAsync(k_FriendNotFoundUrl);
                         pictureBoxFriendNo4.LoadAsync(k_FriendNotFoundUrl);
                         textBoxFriendNo1.Visible = true;

                         break;
                    case 2:
                         pictureBoxFriendNo1.LoadAsync(getUserById(list.ElementAt(0).Key).PictureLargeURL);
                         pictureBoxFriendNo2.LoadAsync(getUserById(list.ElementAt(1).Key).PictureLargeURL);     
                         pictureBoxFriendNo3.LoadAsync(k_FriendNotFoundUrl);
                         pictureBoxFriendNo4.LoadAsync(k_FriendNotFoundUrl);
                         textBoxFriendNo1.Visible = true;
                         textBoxFriendNo2.Visible = true;
                         break;
                    case 3:
                         pictureBoxFriendNo1.LoadAsync(getUserById(list.ElementAt(0).Key).PictureLargeURL);
                         pictureBoxFriendNo2.LoadAsync(getUserById(list.ElementAt(1).Key).PictureLargeURL);  
                         pictureBoxFriendNo3.LoadAsync(getUserById(list.ElementAt(2).Key).PictureLargeURL);
                         pictureBoxFriendNo4.LoadAsync(k_FriendNotFoundUrl);
                         textBoxFriendNo1.Visible = true;
                         textBoxFriendNo2.Visible = true;
                         textBoxFriendNo3.Visible = true;
                         break;
                    default:
                         pictureBoxFriendNo1.LoadAsync(getUserById(list.ElementAt(0).Key).PictureLargeURL);
                         pictureBoxFriendNo2.LoadAsync(getUserById(list.ElementAt(1).Key).PictureLargeURL);  
                         pictureBoxFriendNo3.LoadAsync(getUserById(list.ElementAt(2).Key).PictureLargeURL);
                         pictureBoxFriendNo4.LoadAsync(getUserById(list.ElementAt(3).Key).PictureLargeURL);
                         textBoxFriendNo1.Visible = true;
                         textBoxFriendNo2.Visible = true;
                         textBoxFriendNo3.Visible = true;
                         textBoxFriendNo4.Visible = true;
                         break;
               }

               pictureBoxFriendNo1.Visible = true;
               pictureBoxFriendNo2.Visible = true;
               pictureBoxFriendNo3.Visible = true;
               pictureBoxFriendNo4.Visible = true;
        }
         
        private User getUserById(string i_id)
        {
             User user = null;
             foreach(User friend in m_LoggedInUser.Friends)
             {
                  if(friend.Id == i_id)
                  {
                       user = friend;
                       break;
                  }
             }
             return user;
        }

        
         private void increaseFriendRating(Dictionary<string, int> io_topFriends, string i_friendId)
        {
             if (io_topFriends.ContainsKey(i_friendId) == true)
             {
                  io_topFriends[i_friendId] += 1;
             }
             else
             {
                  io_topFriends.Add(i_friendId, 1);
             }    
        }
         
         private void updateTopFriendsAccordingToSharedEvents(Dictionary<string, int> io_topFriends)
         {
              foreach(Event userEvent in m_LoggedInUser.Events)
              {
                   foreach(User attendingUser in userEvent.AttendingUsers)
                   {
                       // if (m_LoggedInUser.Friends.Contains(attendingUser))
                       Predicate<User> userFinder = (User u) => { return (u.Id == attendingUser.Id); };
                       if (m_LoggedInUser.Friends.Find(userFinder) != null)
                        //if(myContainsUser(m_LoggedInUser.Friends, attendingUser))
                        {
                             increaseFriendRating(io_topFriends, attendingUser.Id);                                                       
                        }
                   }
              }
         }
        


         private void updateTopFriendsAccordingToSharedCheckins(Dictionary<string, int> io_topFriends)
         {
              foreach(Checkin userCheckin in m_LoggedInUser.Checkins)
              {
                   foreach(User taggedUser in userCheckin.WithUsers)
                   {                        
                       Predicate<User> taggedUserFinder = (User u) => { return (u.Id == taggedUser.Id); };
                       if(m_LoggedInUser.Friends.Find(taggedUserFinder) != null)
                       // if (m_LoggedInUser.Friends.Contains(taggedUser))
                        //if (myContainsUser(m_LoggedInUser.Friends, taggedUser))
                        {
                             increaseFriendRating(io_topFriends, taggedUser.Id);
                        }
                   }
              }
         }

         private void updateTopFriendsAccordingToSharedPages(Dictionary<string, int> io_topFriends)
         {
              foreach(Page page in m_LoggedInUser.LikedPages)
              {
                   foreach(User friend in m_LoggedInUser.Friends)
                   {
                       Predicate<Page> pageFinder = (Page p) => { return (p.Id == page.Id); };
                       if (friend.LikedPages.Find(pageFinder) != null)
                        {
                             increaseFriendRating(io_topFriends, friend.Id);
                        }
                   }
              }
         }

         private void updateTopFriendsAccordingToLikesOnPhotos(Dictionary<string, int> io_topFriends)
         {
              foreach(Photo photo in m_LoggedInUser.PhotosTaggedIn)
              {
                   foreach(User userWhoLikedPhoto in photo.LikedBy)
                   {
                       Predicate<User> userFinder = (User u) => { return (u.Id == userWhoLikedPhoto.Id); };
                       if (m_LoggedInUser.Friends.Find(userFinder) != null)
                        {
                             increaseFriendRating(io_topFriends, userWhoLikedPhoto.Id);
                        }
                   }
              }
         }

         private void updateTopFriendsAccordingToCommentsOnPhotos(Dictionary<string, int> io_topFriends)
         {
              foreach(Photo photo in m_LoggedInUser.PhotosTaggedIn)
              {
                  foreach(Comment comment in photo.Comments)
                   {
                       Predicate<User> userFinder = (User u) => { return (u.Id == comment.From.Id); };
                       if (m_LoggedInUser.Friends.Find(userFinder) != null)
                        {
                             User userWhoCommentedOnPhoto = comment.From; // for readability
                             increaseFriendRating(io_topFriends, userWhoCommentedOnPhoto.Id);
                        }
                   }
              }
         }

         private void tabControl1_Selected(object sender, TabControlEventArgs e)
         {
             if (m_LoggedInUser != null)
             {
                 // Eearliest checkin date
                 DateTime earliest = Convert.ToDateTime(m_LoggedInUser.Checkins.Min(record => record.CreatedTime));

                 dateTimePickerFrom.Value = earliest;
                 listBoxFriends.DataSource = m_LoggedInUser.Friends;
                 listBoxFriends.ValueMember = "Id";
                 listBoxFriends.DisplayMember = "Name";
                 listBoxFriends.SelectedIndex = -1;
                 showYourFacebookMarkersOnMap();
             }
         }

         private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
         {
             gmap.Overlays.Clear();
             showYourFacebookMarkersOnMap();

             if (listBoxFriends.SelectedItem != null)
             {
                 showFriendMarkersOnMap((User)listBoxFriends.SelectedItem);
             }  
         }

         private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
         {
             gmap.Overlays.Clear();
             showYourFacebookMarkersOnMap();

             if (listBoxFriends.SelectedItem != null)
             {
                 showFriendMarkersOnMap((User)listBoxFriends.SelectedItem);
             }  
         }

         private void pictureBox4_Click(object sender, EventArgs e)
         {

         }

         private void buttonFriendCheckin_Click(object sender, EventArgs e)
         {
             if (listBoxFriends.SelectedItem != null)
             {
                 showFriendMarkersOnMap((User)listBoxFriends.SelectedItem);
             }  
         }

         private void checkBoxCheckAll_CheckedChanged(object sender, EventArgs e)
         {
              if (checkBoxCheckAll.Text.Equals("Check All"))
              {
                   for (int i = 0; i < checkedListBoxParametersToRateFriends.Items.Count; i++)
                   {
                        checkedListBoxParametersToRateFriends.SetItemChecked(i, true);
                   }
                   checkBoxCheckAll.Text = "Un-Check All";
              }
              else
              {
                   for (int i = 0; i < checkedListBoxParametersToRateFriends.Items.Count; i++)
                   {
                        checkedListBoxParametersToRateFriends.SetItemChecked(i, false);
                   }
                   checkBoxCheckAll.Text = "Check All";
              }
         }

         private void Facebook_Load(object sender, EventArgs e)
         {

         }

         private void textBox1_TextChanged_1(object sender, EventArgs e)
         {

         }
    }
}
