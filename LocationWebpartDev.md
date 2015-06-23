# Components #

The following components are part of the Location WebPart which is used by the organization to show their office loaction on the google map.

## **The actual Web Part** ##
  * This is a **Visual web part** having a user control.
![http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebpartSolution.jpg](http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebpartSolution.jpg)

  * It displays two types of maps depending upon the page mode
    * When the page is in edit mode it shows the map that has a draggable marker which takes the lattitude and longitude of the marker when the page is saved.(Note: the webpart does not needs to be in the edit mode to change the marker position)
![http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebPartEditMode.jpg](http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebPartEditMode.jpg)<br />

  * Otherwise it shows the map whose marker is fixed at the position provided above

  * **Web Part Properties:**
    * Latitude: This is latitude of the organization (Will be set when the marker position is changed when the page is in edit mode).
    * Longitude: This is longitude of the organization (Will be set when the marker position is changed when the page is in edit mode).
    * Title: This is the title of the marker placed on the google map.
    * Display Address: This will display the organization address on the marker.

![http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebpartDetails.jpg](http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebpartDetails.jpg)<br />
![http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationProperties.jpg](http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationProperties.jpg)

## **Visual WebPart** ##
  * **LocationWebPart.cs** is the class that contain the properties needed to show the location on the google map.
  * **It also contains the methods that determine which map to show when and other helping methods
![http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebPart.cs.jpg](http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebPart.cs.jpg)**

  * **LocationWebPartUserControl.ascx** is the file that contains the look & feel and javascript/jQuery of the webpart.
![http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebPart.ascx.jpg](http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/LocationWebPart.ascx.jpg)


---

[Back to Developers RoadMap](http://code.google.com/p/free-sharepoint-small-business-website-template-theme/wiki/DeveloperRoadMap)