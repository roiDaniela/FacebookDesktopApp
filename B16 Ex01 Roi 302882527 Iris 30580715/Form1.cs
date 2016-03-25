using System;
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

namespace B16_Ex01_Roi_302882527_Iris_30580715
{
    public partial class Facebook : Form
    {
        public Facebook()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        User m_LoggedInUser;
        GMapMarker lastMarker;
        double currMaplat;
        double currMapLng;

        private const int k_SharedPhotosCheckedListIndex = 0;
        private const int k_SharedEventsCheckedListIndex = 1;
        private const int k_SharedCheckinsCheckedListIndex = 2;
        private const int k_SharedLikedPagesCheckedListIndex = 3;
        private const int k_LikedMyPhotosCheckedListIndex = 4;
        private const int k_CommentedOnPhotosCheckedListIndex = 5;
        private const int k_LikedMyPostsCheckedListIndex = 6;
        private const int k_CommentedOnPostsCheckedListIndex = 7;

         private class RatedUser
         {
              private int? m_UserID;
              private int m_Score;

              public RatedUser() 
              {
                   m_UserID = null;
                   m_Score = 0;
              }

         }

        private void loginAndInit()
        {
            // Acess Token Roi: "CAAWkQ6soPp0BAPQ1QsZBV3UguaR1WTrT2mSXqvDRGhKJGIBuZBcsNbZCapkQCQxpQVZBZArdDvTNuA8ZCIb4Vbj8PcUhiaQym4weRsUyuwOwfgiuSTYYPpFl9ygBNxuhESppLv8MLM3xgzDcRMAXOnVufuIBespvuB1rIb2Vdkhp6kqeiawaTG6yVtkZCtQDy1KkFlALAn53AZDZD"
            // Acess Token Iris: "CAAWkQ6soPp0BADC8XS19wOmrlTqzgRHtrFWYyWDRv5GAmtW9jtclEZB5Tvp1FVJe7a37WrD44PnExe2rZAqPRQtwb4c8SYyMgjh4WZBlOEfN5p1DkabKFtl0oZASvmlvZCYJbjgTGoQvP9GHj64QIb6EdOgpk9ZAkRgBTy3vyASjuFgkQRnllMVaZAYZAkU1ip0OlJVaWTcbzwZDZD"
            LoginResult result = FacebookService.Connect("CAAWkQ6soPp0BAPQ1QsZBV3UguaR1WTrT2mSXqvDRGhKJGIBuZBcsNbZCapkQCQxpQVZBZArdDvTNuA8ZCIb4Vbj8PcUhiaQym4weRsUyuwOwfgiuSTYYPpFl9ygBNxuhESppLv8MLM3xgzDcRMAXOnVufuIBespvuB1rIb2Vdkhp6kqeiawaTG6yVtkZCtQDy1KkFlALAn53AZDZD");

            /*/// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
            LoginResult result = FacebookService.Login("1587985424858781", 
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",

                //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",

                // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                "read_page_mailboxes",
                // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
                "manage_pages",
                "publish_pages",
                "publish_actions",

                "rsvp_event"
                );
            // These are NOT the complete list of permissions. Other permissions for example:
            // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
            // The documentation regarding facebook login and permissions can be found here: 
            // https://developers.facebook.com/docs/facebook-login/permissions#reference

            */
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            tabControl1.Enabled = true;
        }

        private void showMarkersOnMap()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            double dLongitude;
            double dLatitude;

            foreach (Checkin item in m_LoggedInUser.Checkins)
            {
                if (item.Place.Location != null)
                {
                    dLongitude = Convert.ToDouble(item.Place.Location.Longitude);
                    dLatitude = Convert.ToDouble(item.Place.Location.Latitude);

                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(dLatitude, dLongitude), GMarkerGoogleType.red);
                    marker.ToolTipText = item.Place.Name + " " + item.Place.Location.City;
                    gmap.Overlays.Add(markersOverlay);
                    markersOverlay.Markers.Add(marker);
                }
            }
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
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.DragButton = System.Windows.Forms.MouseButtons.Left;

            checkButtonMinusZoomEnabled();
            checkButtonPlusZoomEnabled();
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string lng = item.Position.Lng.ToString();
            string lat = item.Position.Lat.ToString();

            string s = String.Format("http://www.bing.com/maps/default.aspx?cp={0}~-{1}&ss=yp.YN000x45678&lvl=14&trfc=1", lng, lat);
            webBrowser2.Navigate(s);

            webBrowser1.Navigate(string.Format("https://en.wikipedia.org/wiki/{0}",item.ToolTipText));
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

        private void addChekinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {

            }
        }

        private void removeChekinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                foreach (Checkin checkin in m_LoggedInUser.Checkins)
                {
                    if(checkin.Place.Location.Latitude == lastMarker.Position.Lat &&
                       checkin.Place.Location.Longitude == lastMarker.Position.Lng)
                    {
                        m_LoggedInUser.Checkins.Remove(checkin);

                        gmap.Overlays.Clear();

                        showMarkersOnMap();

                        break;
                    }
                }
            }

            showMarkersOnMap();
        }

        private void gmap_OnMarkerLeave(GMapMarker item)
        {
            // set remove chekin as false
            contextMenuStripAddChekin.Items[1].Enabled = false;

            lastMarker = null;
        }

        private void gmap_OnMarkerEnter(GMapMarker item)
        {
            // set remove chekin as true
            contextMenuStripAddChekin.Items[1].Enabled = true;

            lastMarker = item;
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
         //     Dictionary
              RatedUser[] topFriends = new RatedUser[] {};

              
              if(checkedListBoxParametersToRateFriends.CheckedItems.Count == 0)
              {
                   textBoxNoRateParametersSelected.Visible = true;
              }
              else
              {
                   textBoxNoRateParametersSelected.Visible = false;

                  // if (checkedListBoxParametersToRateFriends.CheckedItems)
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_SharedPhotosCheckedListIndex) == true)
                   {
                        
                   }
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_SharedEventsCheckedListIndex) == true)
                   {
                        UpdateTopFriendsAccordingToSharedEvents(topFriends);   
                   }
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_SharedCheckinsCheckedListIndex) == true)
                   {

                   }
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_SharedLikedPagesCheckedListIndex) == true)
                   {

                   }
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_LikedMyPhotosCheckedListIndex) == true)
                   {

                   }
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_CommentedOnPhotosCheckedListIndex) == true)
                   {

                   }
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_LikedMyPostsCheckedListIndex) == true)
                   {

                   }
                   if (checkedListBoxParametersToRateFriends.CheckedIndices.Contains(k_CommentedOnPostsCheckedListIndex) == true)
                   {

                   }
                   
                   
              }
        }


         private void UpdateTopFriendsAccordingToSharedEvents(RatedUser[] io_topFriends)
         {
              foreach (Event userEvent in m_LoggedInUser.Events)
              {
                   foreach(User attendingUser in userEvent.AttendingUsers)
                   {
                        if (m_LoggedInUser.Friends.Contains(attendingUser))
                        {
                            
                        }
                   }

              }

         }

         private void textBoxNoRateParametersSelected_TextChanged(object sender, EventArgs e)
         {

         }

         private void tabControl1_Selected(object sender, TabControlEventArgs e)
         {
             if (m_LoggedInUser != null)
             {
                 showMarkersOnMap();
             }
         }

         private void contextMenuStripAddChekin_MouseClick(object sender, MouseEventArgs e)
         {
             currMaplat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
             currMapLng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
         }
    }
}
