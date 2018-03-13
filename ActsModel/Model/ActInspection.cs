﻿using System;

namespace ActsModel.Model
{
    // Метки в документе - названия переменных
    public class ActInspection
    {
        // Наименование территориального органа администрации Перми, уполномоченного 
        // на осуществеление муницип. зем. контроля
        public string TerritorialBodyName;

        // Номер акта
        public string ActNum;

        // Дата составления акта
        // “__”	____ 20__г
        public DateTime DateCreation;

        // Место составления и время
        public string PlaceAndTimeCreation;

        // Обследование земельного участка проведено на основании:
        // (указываются реквизиты основания для проведения обследования)
        public string ReasonRequisites;

        // Обследование земельного участка провели:
        // (должность, фамилия, имя, отчество, должность должностного 
        // лица(должностных лиц), проводившего обследование)
        public string CheckContactInfos;

        // Лицо(а), участвовавшее(ие) в обследовании:
        // (фамилия, имя, отчество, должность участвующего(их) в обследовании земельного участка)
        public string InvolvedContactInfos;


        // Произведено обследование земельного участка:
        // (кадастровый номер земельного участка, адрес обследуемой территории)

        // Кадастровый номер зем. участка
        public string CadastralNum;

        // Адрес обследуемой территории
        public string AreaAddress;

        // Площадь земельного участка
        public string AreaSquare;

        // Земельный участок предоставлен...
        // (наименование юридического лица, Ф.И.О. индивидуального предпринимателя,
        // Ф.И.О.физического лица, основание предоставления-указать название, дату
        // и номер документа о предоставлении земельного участка)
        public string ProvidedToInfo;

        // Мероприятия, проводимые в ходе обследования:
        //фотографирование, обмер земельного участка, и другое:
        // (указывается марка фотоаппарата, марка, идентификационные параметры измерительного инструмента)
        public string DeviceParameters;

        // В ходе обследования установлено:
        // (описание территории, строений, сооружений, ограждения и т.д.,
        // наименование юридического лица, Ф.И.О.индивидуального предпринимателя, Ф.И.О.физического лица, использующего земельный участок, площадь
        // земельного участка(фактическая, самовольно занятая), сведения о
        // выявленных нарушениях требований законодательства и(или) требований установленных правовыми актами города Перми)
        public string ResearchResults;

        // Приложения к акту: 
        // (фотоснимки, схема земельного участка, обмер земельного участка)
        public string ActAnnexes;
    }
}