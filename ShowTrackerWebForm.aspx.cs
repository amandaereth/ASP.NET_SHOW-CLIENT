using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowTrackerWebForm : System.Web.UI.Page
   
{
    ShowTrackerClient.ShowTrackerServiceClient db =
       new ShowTrackerClient.ShowTrackerServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDropDownListVenue(); 
        }
        if (!IsPostBack)
        {
            LoadDropDownListArtist();
        }
    }
   
   //Artist
    protected void DropDownListArtist_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridArtist();
    }
    protected void LoadDropDownListArtist()
    {
        string[] artists = db.GetArtists();
        DropDownListArtist.DataSource = artists;
        DropDownListArtist.DataBind();
    }

    protected void FillGridArtist()
    {
        string artist = DropDownListArtist.SelectedItem.Text;
        ShowTrackerClient.ShowLite[] shows = db.GetShowByArtist(artist);
        GridViewArtist.DataSource = shows;
        GridViewArtist.DataBind();
    }
    protected void DropDownListVenue_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridVenue();
    }

    //Venue

    protected void LoadDropDownListVenue()
    {
        string[] venues = db.GetVenues();
        DropDownListVenue.DataSource = venues;
        DropDownListVenue.DataBind();
    }

    protected void FillGridVenue()
    {
        string venue = DropDownListVenue.SelectedItem.Text;
        ShowTrackerClient.ShowLite[] shows = db.GetShowByVenue(venue);
        GridViewVenue.DataSource = shows;
        GridViewVenue.DataBind();
    }

}
