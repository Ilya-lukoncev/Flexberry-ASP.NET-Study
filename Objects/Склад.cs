﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Inter_002
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Склад.
    /// </summary>
    // *** Start programmer edit section *** (Склад CustomAttributes)

    // *** End programmer edit section *** (Склад CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СкладE", new string[] {
            "КодСклада as \'Код склада\'",
            "Адрес as \'Адрес\'"})]
    [View("СкладL", new string[] {
            "КодСклада as \'Код склада\'",
            "Адрес as \'Адрес\'"})]
    public class Склад : ICSSoft.STORMNET.DataObject
    {
        
        private int fКодСклада;
        
        private string fАдрес;
        
        // *** Start programmer edit section *** (Склад CustomMembers)

        // *** End programmer edit section *** (Склад CustomMembers)

        
        /// <summary>
        /// КодСклада.
        /// </summary>
        // *** Start programmer edit section *** (Склад.КодСклада CustomAttributes)

        // *** End programmer edit section *** (Склад.КодСклада CustomAttributes)
        public virtual int КодСклада
        {
            get
            {
                // *** Start programmer edit section *** (Склад.КодСклада Get start)

                // *** End programmer edit section *** (Склад.КодСклада Get start)
                int result = this.fКодСклада;
                // *** Start programmer edit section *** (Склад.КодСклада Get end)

                // *** End programmer edit section *** (Склад.КодСклада Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.КодСклада Set start)

                // *** End programmer edit section *** (Склад.КодСклада Set start)
                this.fКодСклада = value;
                // *** Start programmer edit section *** (Склад.КодСклада Set end)

                // *** End programmer edit section *** (Склад.КодСклада Set end)
            }
        }
        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Адрес CustomAttributes)

        // *** End programmer edit section *** (Склад.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Адрес Get start)

                // *** End programmer edit section *** (Склад.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (Склад.Адрес Get end)

                // *** End programmer edit section *** (Склад.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Адрес Set start)

                // *** End programmer edit section *** (Склад.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (Склад.Адрес Set end)

                // *** End programmer edit section *** (Склад.Адрес Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СкладE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладE", typeof(IIS.Inter_002.Склад));
                }
            }
            
            /// <summary>
            /// "СкладL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладL", typeof(IIS.Inter_002.Склад));
                }
            }
        }
    }
}
