using System;

namespace ActsModel.Model
{
    // ПРОТОКОЛ ОБ АДМИНИСТРАТИВНОМ ПРАВОНАРУШЕНИИ
    public class Protocol : ActIndividual
    {
        /// <summary>
        /// "___" ____________ 20___ г. 
        ///"___" час. "___" мин.
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// N ____________
        /// </summary>
        public string Num;

        /// <summary>
        /// Место составления
        /// </summary> 
        public string CreationPlace;

        /// <summary>
        /// (должность, Ф.И.О. должностного лица, составившего протокол)
        /// </summary>
        public string ActCreatorInfo;

        /// <summary>
        /// в присутсвии 
        /// (должность, наименование юридического лица, должностногo лица, Ф.И.О.законного представителя юридического лица, N доверенности, Ф.И.О. физического лица)
        /// </summary>
        public string InPresenceOfPersonInfo;

        /// <summary>
        /// составил настоящий протокол о нижеследующем: 
        /// (описание нарушения)
        /// </summary>
        public string ViolationDescription;

        /// <summary>
        /// Указанное нарушение допущено:
        /// (наименование юридического лица, руководитель, ИНН, юридический 
        /// адрес, банковские реквизиты, телефоны, Ф.И.О. должностного лица, индивидуального предпринимателя, 
        /// физического лица, ИНН, паспортные данные, адрес регистрации, телефон
        /// </summary>
        public string ViolationAuthorInfo;

        /// <summary>
        /// Данные действия подпадают под часть __ статьи __ Кодекса Российской Федерации об административных правонарушениях.
        /// </summary>
        public string CodexSection;
        public string CodexArticle;

        /// <summary>
        /// Объяснения  лица  (физического,  должностного,  законного представителя юридического лица), 
        /// в   отношении которого   составлен протокол  об административном правонарушении:
        /// </summary>
        public string PersonExplanation;

        /// <summary>
        /// Особые отметки:
        /// </summary>
        public string SpecialMarks;

        /// <summary>
        ///  Лицо, составившее протокол
        /// Ф.И.О., телефон
        /// </summary>
        public string ProtocolCreatorInfo;
    }
}
