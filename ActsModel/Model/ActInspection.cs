using System;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// Метки в документе - названия переменных
    /// </summary>
    [DataContract]
    public class ActInspection : ActCommon
    {
        public ActInspection():base(ActType.АктОбследования){}

        /// <summary>
        /// Наименование территориального органа администрации Перми, уполномоченного 
        /// на осуществеление муницип. зем. контроля
        /// </summary>
        [DataMember]
        public string TerritorialBodyName { get; set; }

        /// <summary>
        ///  Номер акта
        /// </summary>
        [DataMember]
        public string ActNum { get; set; }

        /// <summary>
        /// Дата составления акта
        /// “__”	____ 20__г
        /// </summary>
        [DataMember]
        public DateTime? DateCreation { get; set; }

        /// <summary>
        /// Место составления и время
        /// </summary>
        [DataMember]
        public string PlaceAndTimeCreation { get; set; }

        /// <summary>
        /// Обследование земельного участка проведено на основании:
        /// (указываются реквизиты основания для проведения обследования)
        /// </summary>
        [DataMember]
        public string ReasonRequisites { get; set; }

        /// <summary>
        /// Обследование земельного участка провели:
        /// (должность, фамилия, имя, отчество, должность должностного 
        /// лица(должностных лиц), проводившего обследование)
        /// </summary>
        [DataMember]
        public string CheckContactInfos { get; set; }

        /// <summary>
        /// Лицо(а), участвовавшее(ие) в обследовании:
        /// (фамилия, имя, отчество, должность участвующего(их) в обследовании земельного участка)
        /// </summary>
        [DataMember]
        public string InvolvedContactInfos { get; set; }


        /// <summary>
        /// Произведено обследование земельного участка:
        /// (кадастровый номер земельного участка, адрес обследуемой территории)
        /// Кадастровый номер зем. участка
        /// </summary>
        [DataMember]
        public string CadastralNum { get; set; }

        /// <summary>
        /// Произведено обследование земельного участка:
        /// (кадастровый номер земельного участка, адрес обследуемой территории)
        /// Адрес обследуемой территории
        /// </summary>
        [DataMember]
        public string AreaAddress { get; set; }

        /// <summary>
        /// Площадь земельного участка
        /// </summary>
        [DataMember]
        public string AreaSquare { get; set; }

        /// <summary>
        /// Земельный участок предоставлен...
        /// (наименование юридического лица, Ф.И.О. индивидуального предпринимателя,
        /// Ф.И.О.физического лица, основание предоставления-указать название, дату
        /// и номер документа о предоставлении земельного участка)
        /// </summary>
        [DataMember]
        public string ProvidedToInfo { get; set; }

        /// <summary>
        /// Мероприятия, проводимые в ходе обследования:
        /// фотографирование, обмер земельного участка, и другое:
        /// (указывается марка фотоаппарата, марка, идентификационные параметры измерительного инструмента)
        /// </summary>
        [DataMember]
        public string DeviceParameters { get; set; }

        /// <summary>
        /// В ходе обследования установлено:
        /// (описание территории, строений, сооружений, ограждения и т.д.,
        /// наименование юридического лица, Ф.И.О.индивидуального предпринимателя, Ф.И.О.физического лица, использующего земельный участок, площадь
        /// земельного участка(фактическая, самовольно занятая), сведения о
        /// выявленных нарушениях требований законодательства и(или) требований установленных правовыми актами города Перми)
        /// </summary>
        [DataMember]
        public string ResearchResults { get; set; }

        /// <summary>
        /// Приложения к акту: 
        /// (фотоснимки, схема земельного участка, обмер земельного участка)
        /// </summary>
        [DataMember]
        public string ActAnnexes { get; set; }
    }
}