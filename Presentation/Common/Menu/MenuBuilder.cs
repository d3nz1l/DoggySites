// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuBuilder.cs" company="">
//   
// </copyright>
// <summary>
//   The menu builder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Presentation.Common.Menu
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    /// <summary>
    /// The menu builder.
    /// </summary>
    public class MenuBuilder
    {
        /// <summary>
        /// The make menu.
        /// </summary>
        public void MakeMenu()
        {
            var rootChildren = new List<MenuItem>();

            rootChildren.Add(new MenuItem
                                 {
                                     Action = "About", 
                                     Controller = "Home", 
                                     DisplayText = "About"
                                 });

            rootChildren.Add(new MenuItem
                                 {
                                     Action = "Contact", 
                                     Controller = "Home", 
                                     DisplayText = "Contact"
                                 });

            var exampleDrpDownChildren = new List<MenuItem>();

            exampleDrpDownChildren.Add(new MenuItem
                                 {
                                     Action = "About", 
                                     Controller = "Home", 
                                     DisplayText = "Child1"
                                 });

            exampleDrpDownChildren.Add(new MenuItem
                                 {
                                     Action = "About", 
                                     Controller = "Home", 
                                     DisplayText = "Child2"
                                 });

            exampleDrpDownChildren.Add(new MenuItem
                                 {
                                     Action = "About", 
                                     Controller = "Home", 
                                     DisplayText = "Child3"
                                 });

             rootChildren.Add(new MenuItem
                                 {
                                     DisplayText = "Portfolio", 
                                     Children = exampleDrpDownChildren
                                 });

            var menu = new MenuRoot { Class = "nav navbar-nav navbar-right", Children = rootChildren };

            var serializer = new XmlSerializer(typeof(MenuRoot));
            var writer = new StringWriter();

            serializer.Serialize(writer, menu);

            var menuText = writer.GetStringBuilder().ToString();
        }

        /// <summary>
        /// The build menu.
        /// </summary>
        /// <param name="pathToMenuXml">
        /// The path to menu xml.
        /// </param>
        /// <typeparam name="T">
        /// The menu type
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T BuildMenu<T>(string pathToMenuXml)
        {
            if (string.IsNullOrEmpty(pathToMenuXml) || !File.Exists(pathToMenuXml))
            {
                throw new InvalidOperationException("The supplied Menu XML doesn't exist. " + pathToMenuXml);
            }

            return this.DeserializeMenu<T>(pathToMenuXml);
        }

        /// <summary>
        /// The deserialize menu.
        /// </summary>
        /// <param name="xmlPath">
        /// The xml path.
        /// </param>
        /// <typeparam name="T">
        /// The menu type
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        private T DeserializeMenu<T>(string xmlPath)
        {
            var serializer = new XmlSerializer(typeof(T));

            var menu = default(T);

            using (var reader = File.OpenRead(xmlPath))
            {
                menu = (T)serializer.Deserialize(reader);
            }

            return menu;
        }
    }
}
