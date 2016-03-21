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
        List<Checkin> m_LocationCheckInList = new List<Checkin>();

        private void loginAndInit()
        {
            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
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
            
            // Add all chekins
            foreach (Checkin checkin in m_LoggedInUser.Checkins)
            {
                m_LocationCheckInList.Add(checkin);
            }
        }

        private void showMarkersOnMap()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            double dLongitude;
            double dLatitude;

            foreach (Checkin item in m_LocationCheckInList)
            {
                dLongitude = Convert.ToDouble(item.Place.Location.Longitude);
                dLatitude = Convert.ToDouble(item.Place.Location.Latitude);

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(dLongitude, dLatitude), GMarkerGoogleType.red);
                marker.ToolTipText = item.Place.Location.City;
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            // Initialize map:
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.DragButton = System.Windows.Forms.MouseButtons.Left;
            gmap.Zoom = 1;

            showMarkersOnMap();
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string lng = item.Position.Lng.ToString();
            string lat = item.Position.Lat.ToString();

            string s = String.Format("https://www.google.com/maps?ll={0},{1}", lng, lat);
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
    }
}
