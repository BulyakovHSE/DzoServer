﻿using System;

namespace ActsModel.Model
{
    /// <summary>
    /// Метки в документе - названия переменных
    /// </summary>
    public class ActInspection : ActCommon
    {
        /// <summary>
        /// Наименование территориального органа администрации Перми, уполномоченного 
        /// на осуществеление муницип. зем. контроля
        /// </summary>
        public string TerritorialBodyName;

        /// <summary>
        ///  Номер акта
        /// </summary>
        public string ActNum;

        /// <summary>
        /// Дата составления акта
        /// “__”	____ 20__г
        /// </summary>
        public DateTime DateCreation;

        /// <summary>
        /// Место составления и время
        /// </summary>
        public string PlaceAndTimeCreation;

        /// <summary>
        /// Обследование земельного участка проведено на основании:
        /// (указываются реквизиты основания для проведения обследования)
        /// </summary>
        public string ReasonRequisites;

        /// <summary>
        /// Обследование земельного участка провели:
        /// (должность, фамилия, имя, отчество, должность должностного 
        /// лица(должностных лиц), проводившего обследование)
        /// </summary>
        public string CheckContactInfos;

        /// <summary>
        /// Лицо(а), участвовавшее(ие) в обследовании:
        /// (фамилия, имя, отчество, должность участвующего(их) в обследовании земельного участка)
        /// </summary>
        public string InvolvedContactInfos;


        /// <summary>
        /// Произведено обследование земельного участка:
        /// (кадастровый номер земельного участка, адрес обследуемой территории)
        /// Кадастровый номер зем. участка
        /// </summary>
        public string CadastralNum;

        /// <summary>
        /// Произведено обследование земельного участка:
        /// (кадастровый номер земельного участка, адрес обследуемой территории)
        /// Адрес обследуемой территории
        /// </summary>
        public string AreaAddress;

        /// <summary>
        /// Площадь земельного участка
        /// </summary>
        public string AreaSquare;

        /// <summary>
        /// Земельный участок предоставлен...
        /// (наименование юридического лица, Ф.И.О. индивидуального предпринимателя,
        /// Ф.И.О.физического лица, основание предоставления-указать название, дату
        /// и номер документа о предоставлении земельного участка)
        /// </summary>
        public string ProvidedToInfo;

        /// <summary>
        /// Мероприятия, проводимые в ходе обследования:
        /// фотографирование, обмер земельного участка, и другое:
        /// (указывается марка фотоаппарата, марка, идентификационные параметры измерительного инструмента)
        /// </summary>
        public string DeviceParameters;

        /// <summary>
        /// В ходе обследования установлено:
        /// (описание территории, строений, сооружений, ограждения и т.д.,
        /// наименование юридического лица, Ф.И.О.индивидуального предпринимателя, Ф.И.О.физического лица, использующего земельный участок, площадь
        /// земельного участка(фактическая, самовольно занятая), сведения о
        /// выявленных нарушениях требований законодательства и(или) требований установленных правовыми актами города Перми)
        /// </summary>
        public string ResearchResults;

        /// <summary>
        /// Приложения к акту: 
        /// (фотоснимки, схема земельного участка, обмер земельного участка)
        /// </summary>
        public string ActAnnexes;
    }
}