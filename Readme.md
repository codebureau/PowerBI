# Power BI Tools and Utilities

## SharePoint URL Fixer
A simple desktop application, to be integrated as a Power BI External Tool.
This (optionally) reads the clipboard upon open, and strips unhelpful SharePoint file type markers as per https://sharepointmaven.com/the-anatomy-of-a-sharepoint-url/

* ":f/" means Folder sharing
* ":w/" means Word document sharing
* ":x/" means Excel document sharing
* ":p/" means PowerPoint document sharing
* ":b/" means PDF document sharing

The resulting URL can then be easily copied in order to import to Power BI.