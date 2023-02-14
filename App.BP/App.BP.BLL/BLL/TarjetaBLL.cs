using App.BP.BLL.Interfaces;
using App.BP.Common;
using App.BP.Common.DTO;
using App.BP.Data.Models;
using App.BP.Repository.Interfaces;
using System.Reflection;

namespace App.BP.BLL.BLL
{
    public class TarjetaBLL : ITarjetaBLL
    {
        private IRepository<ChlCardBaseInfo> _repositoryChlCardBaseInfo;

        public TarjetaBLL(IRepository<ChlCardBaseInfo> repositoryChlCardBaseInfo)
        {
            _repositoryChlCardBaseInfo = repositoryChlCardBaseInfo;
        }

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroTarjeta"></param>
        /// <returns>Una tarjeta</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<TarjetaResumen> ObtenerTarjeta(string numeroTarjeta)
        {
            var resultQuery = await _repositoryChlCardBaseInfo.SearchByAsync(c => c.CardNumber == numeroTarjeta);

            ChlCardBaseInfo record = resultQuery.FirstOrDefault();

            TarjetaResumen tarjetaResumen = ObtenerTarjetaResumen(record);

            return tarjetaResumen;
        }
        #endregion

        #region Private Methods
        private TarjetaResumen ObtenerTarjetaResumen(ChlCardBaseInfo record)
        {
            TarjetaResumen tarjetaResumen = new TarjetaResumen();

            tarjetaResumen.TarjetasAsociadas = ObtenerTarjetasAsociadas(record);
            tarjetaResumen.TarjetaInformacion = ObtenerTarjetaInformacion(record);
            return tarjetaResumen;
        }

        private TarjetaInformacion ObtenerTarjetaInformacion(ChlCardBaseInfo record)
        {
            TarjetaInformacion tarjetaInformacion = new TarjetaInformacion
            {
                CARD_CUSTOMER_CARD_NAME = record.CardCustomerCardName,
                CARD_ACCT_COUNT = record.CardAcctCount,
                CARD_DELIVERY_DATE = record.CardDeliveryDate,
                CARD_DELIVERY_OFFICE = record.CardDeliveryOffice,
                CARD_EXPIRATION_DATE = record.CardExpirationDate,
                CARD_FIRST_USE_DATE = record.CardFirstUseDate,
                CARD_INSTITUTION = record.CardInstitution,
                CARD_LAST_USE_DATE = record.CardLastUseDate,
                CARD_ISSUE_DATE = record.CardIssueDate,
                CARD_ISSUE_OFFICE = record.CardIssueOffice,
                CARD_LAST_PIN_CHANGE = record.CardLastPinChange,
                CARD_LAST_STATUS_CHANGE = record.CardLastStatusChange,
                CARD_LIMIT_RESET_PERIOD = record.CardLimitResetPeriod,
                CARD_MANDATORY_PIN_CHANGE = record.CardMandatoryPinChange,
                CARD_MOB_COUNT = record.CardMobCount,
                CARD_MOB_COUNT_LIMIT = record.CardMobCountLimit,
                CARD_MOB_LIMIT = record.CardMobLimit,
                CARD_MOB_USED = record.CardMobUsed,
                CARD_NETWORK_ID = record.CardNetworkId,
                CARD_NEXT_PIN_CHANGE = record.CardNextPinChange,
                CARD_NUMBER = record.CardNumber,
                CARD_OWNER_ID = record.CardOwnerId,
                CARD_OWNER_ID_TYPE = record.CardOwnerIdType,
                CARD_PIN_FAIL_COUNT = record.CardPinFailCount,
                CARD_PIN_FAIL_LIMIT = record.CardPinFailLimit,
                CARD_PIN_OFFSET = record.CardPinOffset,
                CARD_POS_COUNT = record.CardPosCount,
                CARD_POS_COUNT_LIMIT = record.CardPosCountLimit,
                CARD_POS_LIMIT = record.CardPosLimit,
                CARD_POS_USED = record.CardPosUsed,
                CARD_REISSUE_DATE = record.CardReissueDate,
                CARD_STATUS = record.CardStatus,
                CARD_TNP_COUNT = record.CardTnpCount,
                CARD_TNP_COUNT_LIMIT = record.CardTnpCountLimit,
                CARD_TNP_LIMIT = record.CardTnpLimit,
                CARD_TNP_USED = record.CardTnpUsed,
                CARD_TYPE = record.CardType,
                CARD_WD_COUNT = record.CardWdCount,
                CARD_WD_COUNT_LIMIT = record.CardWdCountLimit,
                CARD_WD_LIMIT = record.CardWdLimit,
                CARD_WD_USED = record.CardWdUsed,
                CARD_XFR_COUNT = record.CardXfrCount,
                CARD_XFR_COUNT_LIMIT = record.CardXfrCountLimit,
                CARD_XFR_LIMIT = record.CardXfrLimit,
                CARD_XFR_OTHERS_LIMIT = record.CardXfrOthersLimit,
                CARD_XFR_OTHERS_USED = record.CardXfrOthersUsed,
                CARD_XFR_USED = record.CardXfrUsed
            };
            return tarjetaInformacion;
        }

        /// <summary>
        /// Permite retornar un listado de las tarjetas asociadas a una tarjeta
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        private List<TarjetaAsociada> ObtenerTarjetasAsociadas(ChlCardBaseInfo record)
        {
            List<TarjetaAsociada> tarjetasAsociadas = new List<TarjetaAsociada>();
            bool insertarTarjeta = false;

            PropertyInfo[] propiedades = typeof(ChlCardBaseInfo).GetProperties();

            List<PropertyInfo> propiedadesCardAcctType = propiedades.Where(p => p.Name.Contains("CardAcctType")).ToList();
            List<PropertyInfo> propiedadesCardAcctNumber = propiedades.Where(p => p.Name.Contains("CardAcctNumber")).ToList();
            List<PropertyInfo> propiedadesCardAcctUse = propiedades.Where(p => p.Name.Contains("CardAcctUse")).ToList();

            //En la tabla existen 20 columnas quedamas para identificar las tarjetas asociadas
            for (int i = 0; i < 20; i++)
            {
                TarjetaAsociada tarjetaAsociada = new TarjetaAsociada();
                string cardAcctType = propiedadesCardAcctType[i].GetValue(record).ToString();
                string cardAcctNumber = propiedadesCardAcctNumber[i].GetValue(record).ToString();
                string cardAcctUse = propiedadesCardAcctUse[i].GetValue(record).ToString();

                if (cardAcctType == Constantes.CardAcctTypeEmpty || cardAcctNumber == Constantes.CardAcctNumberEmpty)
                {
                    break;
                }

                tarjetaAsociada.CARD_ACCT_TYPE = cardAcctType;
                tarjetaAsociada.CARD_ACCT_NUMBER = cardAcctNumber;
                tarjetaAsociada.CARD_ACCT_USE = cardAcctUse;
                tarjetasAsociadas.Add(tarjetaAsociada);
            }

            return tarjetasAsociadas;
        }
        #endregion
    }
}
