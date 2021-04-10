/*==============================================================================================================================
| Author        Katie Oliveras
| Project       Website
\=============================================================================================================================*/
using System.Collections.Generic;

namespace KatieOliveras.Web.Services {

  /*============================================================================================================================
  | CLASS: SITE
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides access to global constants and methods needed across the site.
  /// </summary>
  public static class Site {

    /*==========================================================================================================================
    | NAVIGATION
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   A <see cref="Dictionary{TKey, TValue}"/> of navigation items, where the <see cref="KeyValuePair{TKey, TValue}.Key"/>
    ///   represents the folder name, and <see cref="KeyValuePair{TKey, TValue}.Value"/> represents the friendly label.
    /// </summary>
    public static IReadOnlyDictionary<string, string> Navigation { get; } = new Dictionary<string, string>() {
      { "",                   "Home" },
      { "Publications",       "Publications" },
      { "Research",           "Research" },
      { "Teaching",           "Teaching" },
      { "UndergradResearch",  "Undergraduate Research" },
      { "Schedule",           "Office Scheule" },
      { "Contact",            "Contact" }
    };

} //Class
} //Namespace