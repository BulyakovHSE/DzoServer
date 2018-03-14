using System;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// ПРОТОКОЛ ОБ АДМИНИСТРАТИВНОМ ПРАВОНАРУШЕНИИ
    /// </summary>
    [DataContract]
    public class Protocol : ActIndividual
    {
        /// <summary>
        /// "___" ____________ 20___ г. 
        ///"___" час. "___" мин.
        /// </summary>
        [DataMember]
        public DateTime? Date { get; set; }

        /// <summary>
        /// N ____________
        /// </summary>
        [DataMember]
        public string Num { get; set; }

        /// <summary>
        /// Место составления
        /// </summary>
        [DataMember] 
        public string CreationPlace { get; set; }

        /// <summary>
        /// (должность, Ф.И.О. должностного лица, составившего протокол)
        /// </summary>
        [DataMember]
        public string ActCreatorInfo { get; set; }

        /// <summary>
        /// в присутсвии 
        /// (должность, наименование юридического лица, должностногo лица, Ф.И.О.законного представителя юридического лица, N доверенности, Ф.И.О. физического лица)
        /// </summary>
        [DataMember]
        public string InPresenceOfPersonInfo { get; set; }

        /// <summary>
        /// составил настоящий протокол о нижеследующем: 
        /// (описание нарушения)
        /// </summary>
        [DataMember]
        public string ViolationDescription { get; set; }

        /// <summary>
        /// Указанное нарушение допущено:
        /// (наименование юридического лица, руководитель, ИНН, юридический 
        /// адрес, банковские реквизиты, телефоны, Ф.И.О. должностного лица, индивидуального предпринимателя, 
        /// физического лица, ИНН, паспортные данные, адрес регистрации, телефон
        /// </summary>
        [DataMember]
        public string ViolationAuthorInfo { get; set; }

        /// <summary>
        /// Данные действия подпадают под часть __ статьи __ Кодекса Российской Федерации об административных правонарушениях.
        /// </summary>
        [DataMember]
        public string CodexSection { get; set; }
        [DataMember]
        public string CodexArticle { get; set; }

        /// <summary>
        /// Объяснения  лица  (физического,  должностного,  законного представителя юридического лица), 
        /// в   отношении которого   составлен протокол  об административном правонарушении:
        /// </summary>
        [DataMember]
        public string PersonExplanation { get; set; }

        /// <summary>
        /// Особые отметки:
        /// </summary>
        [DataMember]
        public string SpecialMarks { get; set; }

        /// <summary>
        ///  Лицо, составившее протокол
        /// Ф.И.О., телефон
        /// </summary>
        [DataMember]
        public string ProtocolCreatorInfo { get; set; }
    }
}
