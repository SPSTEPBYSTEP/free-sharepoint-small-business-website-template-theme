# Code Structure #

  * This template is packaged as a wsp that can be deployed to any SharePoint server, which increases its re-usability.
  * The structure of the code is highlighted in the screenshot below:
![http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/ActualCodeStructure.jpg](http://free-sharepoint-small-business-website-template-theme.googlecode.com/svn/wiki/Images/ActualCodeStructure.jpg)
  * Describing the above components:
    1. **Features:** There are 2 features:
      * A Site scoped feature - Query Us WebPart, Location WebPart, Services WebPart, Contact us Address WebPart.
      * A Web scoped feature - Consisting of all the other modules (Master Page, Theme, Page Layout Content Type, Internal Pages, Images, Custom page Layout, CSS). This feature also has a receiver which gets triggered when the feature is activated.
    1. **BrickRed.SmallBusiness:** The custom content type for page layout
    1. **ContactUsWebPart:** The Query Us WebPart that is a user can use to send queries to the site administrators.
    1. **LocationWebPart:** The Location WebPart is for adding the location of the organization on the google map embeded in the site.
    1. **ServicesWebPart:** The Services WebPart is for showing the services offered by the organization on the home page.
    1. **ContactUsAddressWebPart:** The Contact Us Address WebPart is for showing the organization contact details.
    1. **ControlTemplates:** This folder contains the 2 custom user controls, which are placed in the 14 Hive under the ControlTemplates folder within Templates.
      * Footer Control
      * Header Contact Us Control
    1. **CssClass:** This module contains the CSS class used in this template and places the same in the Style Library.
    1. **DetailedServicesOffered:** This WebPart is for showing the services offered by the organization on the Services page.
    1. **Images:** This module contains all the images of the site and places them in the PublishingImages Library on the site.
    1. **LayoutPages:** This module contains the Home Page and internal pages that are !pre-created when the site is created. It also places these pages in the Pages Library.
    1. **Layouts:** This is the 14 hive Layouts folder, which contains the JS files (**BrickRed.SmallBusiness.js & jquery-1.6.2.min.js**)
    1. **MasterPages:** This module contains the master page for the site (**BrickRed.SmallBusiness.master**), and places the same in the master page and page layout gallery on the site.
    1. **MasterPagesGallery:** This module contains the custom page layouts (**Home Page Layout and Inner Page Layout**) and places these in the Master Page and page layout gallery on the site.
    1. **ServicesOffered:** This module contains the images of the services offered webpart and places them in the Service List of type Picture Library.
    1. **SiteDefinition:** This contains the Onet.XML file which is the main component using which the site is created. Both the features are getting activated by default within this file.
    1. **Themes:** This module contains the theme (**BrickRedSmallBusiness.thmx**) file which is placed in the Themes gallery on the site.
    1. **Constants.cs:** This class file contains all the global constants used in the solution
    1. **SendMail.cs:** This class file contains the common methods being used in order to Send the mails in the system.

There are the main components in the code, which are further discussed in details in the next sections of the Developer Roadmap.

---

[Back to Developers RoadMap](http://code.google.com/p/free-sharepoint-small-business-website-template-theme/wiki/DeveloperRoadMap)