﻿using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
using System.Collections.Generic;

namespace BrickRed.Templates.SmallBusiness.ContactUsAddressWebPart
{
    [ToolboxItemAttribute(false)]
    public class ContactUsAddressWebPart : Microsoft.SharePoint.WebPartPages.WebPart, IWebEditable
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/BrickRed.Templates.SmallBusiness/ContactUsAddressWebPart/ContactUsAddressWebPartUserControl.ascx";


        #region Webpart Properties
        private string _companyName = "Company Name Pvt Ltd";
        private string _companyAddress = "1234 ABC Lane\r\nDrive 1234\r\nLocation\r\nPhone: +1.234.567.8901\r\nFax: +1.234.567.8901\r\nEmail: yourcompany@email.com\r\n";

        [WebBrowsable(false),
        Personalizable(PersonalizationScope.Shared)]
        public string CompanyName
        {
            get
            {
                ContactUsAddressWebPartUserControl.CompanyName = _companyName;
                return _companyName;
            }
            set 
            {
                ContactUsAddressWebPartUserControl.CompanyName = value;
                _companyName = value; 
            }
        }



        [WebBrowsable(false),
        Personalizable(PersonalizationScope.Shared)]
        public string CompanyAddress
        {

            get
            {
                ContactUsAddressWebPartUserControl.CompanyAddress = _companyAddress; 
                return _companyAddress;
            }
            set 
            {
                ContactUsAddressWebPartUserControl.CompanyAddress = value;
                _companyAddress = value;
            }
        }

        #endregion

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }

        #region IWebEditable Members

        EditorPartCollection IWebEditable.CreateEditorParts()
        {
            EditorPartCollection defaultEditor = base.CreateEditorParts();
            List<EditorPart> editors = new List<EditorPart>();
            editors.Add(new ContactUsAddressEditorPart(this.ID));
            return new EditorPartCollection(defaultEditor, editors);
        }

        object IWebEditable.WebBrowsableObject
        {
            get { return this; }
        }

        #endregion
    }
}
