﻿using System;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// АКТ ПРОВЕРКИ ЮЛ,ИП
    /// </summary>
    [DataContract] 
    public class ActInspectationUlIp : ActCommon
    {
        public ActInspectationUlIp():base(ActType.АктПроверкиЮл){}

        /// <summary>
        /// Наименование территориального органа администрации Перми, уполномоченного 
        /// на осуществеление муницип. зем. контроля
        /// </summary>
        [DataMember]
        public string TerritorialBodyName { get; set; }

        /// <summary>
        ///  Место составления
        /// </summary>
        [DataMember]
        public string PlaceActCreation { get; set; }

        /// <summary>
        /// Дата и время составления акта
        /// “__”	____ 20__г.
        /// </summary>
        [DataMember]
        public DateTime? DateTimeCreation { get; set; }

        /// <summary>
        /// Номер акта проверки
        /// </summary>
        [DataMember]
        public string ActNum { get; set; }

        /// <summary>
        /// По адресу/адресам:  
        /// (место проведения проверки)
        /// </summary>
        [DataMember]
        public string CheckingPlace { get; set; }

        /// <summary>
        /// На основании:
        /// (вид документа с указанием реквизитов (номер, дата))
        /// </summary>
        [DataMember]
        public string OnBaseOfDocs { get; set; }

        /// <summary>
        /// была проведена  
        /// (плановая/внеплановая, документарная/выездная)
        /// </summary>
        [DataMember]
        public string CheckType { get; set; }

        /// <summary>
        ///  проверка в отношении:
        /// (наименование юридического лица, фамилия, имя, отчество (последнее – при наличии)
        /// индивидуального предпринимателя)
        /// </summary>
        [DataMember]
        public string ChekingTarget { get; set; }

        /// <summary>
        /// Дата и время проведения проверки:
        /// (заполняется в случае проведения проверок филиалов, представительств,  обособленных структурных
        /// подразделений юридического лица или  при осуществлении деятельности индивидуального предпринимателя
        /// по нескольким адресам)
        /// !!ВИДИМО МОЖЕТ БЫТЬ НЕСКОЛЬКО СТРОК!! ТАКОГО ТИПА
        /// “__” ____ 20__г. с	__час.	__мин. до __час. __мин. Продолжительность __
        /// </summary>
        [DataMember]
        public string DateAndTimeOfCheck { get; set; }

        /// <summary>
        /// Общая продолжительность проверки:
        /// (рабочих дней/часов)
        /// </summary>
        [DataMember]
        public string CommonCheckDuration { get; set; }

        /// <summary>
        /// Акт составлен:
        /// (наименование органа государственного контроля (надзора) или органа муниципального контроля)
        /// </summary>
        [DataMember]
        public string ActCreatedBy { get; set; }

        /// <summary>
        /// С копией распоряжения/приказа о проведении проверки ознакомлен(ы): 
        /// (заполняется при проведении выездной проверки)
        /// ((фамилии, инициалы, подпись, дата, время)
        /// </summary>
        [DataMember]
        public string FamiliarPersonInfo { get; set; }

        /// <summary>
        /// Дата и номер решения прокурора (его заместителя) о согласовании проведения проверки:
        /// ((заполняется в случае необходимости согласования проверки с органами прокуратуры)
        /// </summary>
        [DataMember]
        public string ProsecutorDecision { get; set; }

        /// <summary>
        /// Лицо(а), проводившее проверку:  
        /// (фамилия, имя, отчество (последнее – при наличии), должность должностного лица (должностных лиц), проводившего(их) проверку; 
        /// в случае привлечения к участию в проверке экспертов, экспертных организаций указываются фамилии, имена, отчества (последнее – при наличии), 
        /// должности экспертов и/или наименования экспертных организаций с указанием реквизитов свидетельства об аккредитации и наименование органа
        /// по аккредитации, выдавшего свидетельство)
        /// </summary>
        [DataMember]
        public string CheckersInfo { get; set; }

        /// <summary>
        /// При проведении проверки присутствовали:
        /// (фамилия, имя, отчество (последнее – при наличии), должность руководителя, 
        /// иного должностного лица (должностных лиц) или уполномоченного представителя юридического лица, 
        /// уполномоченного представителя индивидуального предпринимателя, 
        /// уполномоченного представителя саморегулируемой организации (в случае проведения проверки члена саморегулируемой организации),
        /// присутствовавших при проведении мероприятий по проверке)
        /// </summary>
        [DataMember]
        public string BeholdersInfo { get; set; }

        /// <summary>
        /// В ходе проведения проверки:
        /// выявлены нарушения обязательных требований или требований, 
        /// установленных муниципальными правовыми актами с указанием положений (нормативных) правовых актов)
        /// (с указанием характера нарушений; лиц, допустивших нарушения)
        /// </summary>
        [DataMember]
        public string RequirementsViolations { get; set; }

        /// <summary>
        /// выявлены несоответствия сведений, содержащихся в уведомлении о начале осуществления отдельных видов предпринимательской деятельности,
        /// обязательным требованиям (с указанием положений (нормативных) правовых актов):
        /// </summary>
        [DataMember]
        public string DiscrepanciesInfo { get; set; }

        /// <summary>
        /// выявлены факты невыполнения предписаний органов государственного контроля 
        /// (надзора), органов муниципального контроля (с указанием реквизитов выданных предписаний):
        /// </summary>
        [DataMember]
        public string NonComplianceFacts { get; set; }

        /// <summary>
        /// нарушений не выявлено
        /// </summary>
        [DataMember]
        public string NoViolations { get; set; }

        /// <summary>
        /// Прилагаемые к акту документы:
        /// </summary>
        public string DocsForAct { get; set; }

        /// <summary>
        ///  С актом проверки ознакомлен(а), копию акта со всеми приложениями получил(а):
        /// (фамилия, имя, отчество (последнее – при наличии), должность руководителя, иного должностного лица
        /// или уполномоченного представителя юридического лица, индивидуального предпринимателя,
        /// его уполномоченного представителя)
        /// </summary>
        [DataMember]
        public string PersonInfo { get; set; }
    }
}
