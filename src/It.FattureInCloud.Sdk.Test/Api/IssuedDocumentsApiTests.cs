/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;
using Moq;
using It.FattureInCloud.Sdk.Client;
using It.FattureInCloud.Sdk.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using It.FattureInCloud.Sdk.Model;

namespace It.FattureInCloud.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing IssuedDocumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IssuedDocumentsApiTests : IDisposable
    {
        Mock<IIssuedDocumentsApi> instance = new Mock<IIssuedDocumentsApi>();
        string createIssuedDocumentResponseBody;
        string getEmailDataResponseBody;
        string getExistingIssuedDocumentTotalsResponseBody;
        string getIssuedDocumentResponseBody;
        string getIssuedDocumentPreCreateInfoResponseBody;
        string getNewIssuedDocumentTotalsResponseBody;
        string listIssuedDocumentsResponseBody;
        string modifyIssuedDocumentResponseBody;
        string uploadIssuedDocumentAttachmentResponseBody;
        string transformIssuedDocumentResponseBody;
        string joinIssuedDocumentsResponseBody;

        public IssuedDocumentsApiTests()
        {
            createIssuedDocumentResponseBody = "{ 'data': { 'type': 'receipt', 'show_totals': 'all', 'id': 12345, 'number': 1, 'numeration': 'rec123', 'date': '2021-08-20', 'year': 2021, 'currency': { 'id': 'EUR', 'symbol': '€', 'exchange_rate': '1.00000' }, 'language': { 'code': 'it', 'name': 'Italiano' }, 'subject': '', 'visible_subject': '', 'rc_center': '', 'notes': '', 'withholding_tax_taxable': 100.0, 'payment_method': { 'id': 4, 'name': 'Credit card', 'is_default': false, }, 'use_split_payment': false, 'use_gross_prices': false, 'e_invoice': false, 'items_list': [ { 'product_id': 5432, 'code': 'SG3', 'name': 'Soggiorno', 'description': '', 'qty': 1.0, 'measure': '', 'net_price': 68.18182, 'gross_price': 75.0, 'vat': { 'id': 3, 'value': 10.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'not_taxable': false, 'apply_withholding_taxes': true, 'discount_highlight': false, 'in_ddt': false, 'stock': false } ], 'payments_list': [ { 'status': 'not_paid', 'due_date': '2020-08-23', 'amount': 75.0, 'paid_date': '2020-08-23' } ], 'template': { 'id': 2821, 'name': 'Light Smoke' }, 'h_margins': 15, 'v_margins': 16, 'show_payments': true, 'show_payment_method': false, 'show_paypal_button': true, 'show_notification_button': false, 'show_tspay_button': false, 'delivery_note': false, 'accompanying_invoice': false, 'is_marked': false, 'next_due_date': '2020-08-23', 'url': 'y12h45rn9yf2mse0p43t7ec90vr.pdf' } }";
            var listArchiveCategoriesResponse = JsonConvert.DeserializeObject<CreateIssuedDocumentResponse>(createIssuedDocumentResponseBody);
            instance
                .Setup(p => p.CreateIssuedDocument(Moq.It.IsAny<int>(), Moq.It.IsAny<CreateIssuedDocumentRequest>(), 0))
                .Returns(listArchiveCategoriesResponse);

            getEmailDataResponseBody = "{'data':{'recipient_email':'mary.red@example.com','default_sender_email':{'email':'no-reply@fattureincloud.it'},'sender_emails_list':[{'email':'no-reply@fattureincloud.it'},{'id':888,'email':'mariorossi@fattureincloud.it'}],'cc_email':'m.rossi@exxample.com','subject':'Nostra pro forma nr. 1','body':'Gentile Mario Rossi,<br>per vedere la nostra pro forma di  o per scaricarne una copia in versione PDF prema sul bottone sottoastante.<br><br>{{allegati}}<br><br>Cordiali saluti,<br><b>Mario Rossi</b>','document_exists':true,'delivery_note_exists':false,'attachment_exists':false,'accompanying_invoice_exists':false,'default_attach_pdf':false}}";
            var getEmailDataResponse = JsonConvert.DeserializeObject<GetEmailDataResponse>(getEmailDataResponseBody);
            instance
                .Setup(p => p.GetEmailData(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), 0))
                .Returns(getEmailDataResponse);

            getExistingIssuedDocumentTotalsResponseBody = "{ 'data': { 'amount_net': 68.18, 'amount_rivalsa': 13.64, 'amount_net_with_rivalsa': 81.82, 'taxable_amount': 81.82, 'amount_vat': 8.18, 'amount_gross': 90.0, 'amount_due': 90.0, 'is_enasarco_maximal_exceeded': false, 'payments_sum': 75.0, 'vat_list': {} }}";
            var getExistingIssuedDocumentTotalsResponse = JsonConvert.DeserializeObject<GetExistingIssuedDocumentTotalsResponse>(getExistingIssuedDocumentTotalsResponseBody);
            instance
                .Setup(p => p.GetExistingIssuedDocumentTotals(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<GetExistingIssuedDocumentTotalsRequest>(), 0))
                .Returns(getExistingIssuedDocumentTotalsResponse);

            getIssuedDocumentResponseBody = "{ 'data': { 'type': 'receipt', 'show_totals': 'all', 'id': 12345, 'number': 1, 'numeration': 'rec123', 'date': '2021-08-20', 'year': 2021, 'currency': { 'id': 'EUR', 'symbol': '€', 'exchange_rate': '1.00000' }, 'language': { 'code': 'it', 'name': 'Italiano' }, 'subject': '', 'visible_subject': '', 'rc_center': '', 'notes': '', 'withholding_tax_taxable': 100.0, 'payment_method': { 'id': 4, 'name': 'Credit card', 'is_default': false, }, 'use_split_payment': false, 'use_gross_prices': false, 'e_invoice': false, 'items_list': [ { 'product_id': 5432, 'code': 'SG3', 'name': 'Soggiorno', 'description': '', 'qty': 1.0, 'measure': '', 'net_price': 68.18182, 'gross_price': 75.0, 'vat': { 'id': 3, 'value': 10.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'not_taxable': false, 'apply_withholding_taxes': true, 'discount_highlight': false, 'in_ddt': false, 'stock': false } ], 'payments_list': [ { 'status': 'not_paid', 'due_date': '2020-08-23', 'amount': 75.0, 'paid_date': '2020-08-23' } ], 'template': { 'id': 2821, 'name': 'Light Smoke' }, 'h_margins': 15, 'v_margins': 16, 'show_payments': true, 'show_payment_method': false, 'show_paypal_button': true, 'show_notification_button': false, 'show_tspay_button': false, 'delivery_note': false, 'accompanying_invoice': false, 'is_marked': false, 'next_due_date': '2020-08-23', 'url': 'y12h45rn9yf2mse0p43t7ec90vr.pdf' } }";
            var getIssuedDocumentResponse = JsonConvert.DeserializeObject<GetIssuedDocumentResponse>(getIssuedDocumentResponseBody);
            instance
                .Setup(p => p.GetIssuedDocument(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), 0))
                .Returns(getIssuedDocumentResponse);

            getIssuedDocumentPreCreateInfoResponseBody = "{'data':{'numerations':{'2018':{'AB123':2},'2019':{'123':0},'2020':{'ABC':2},'2021':{'rec123':2}},'dn_numerations':{'2017':{'':1000},'2018':{'':112},'2019':{'':526},'2020':{'':11},'2021':{'':110}},'default_values':{'dn_template':{'id':222,'name':'DDT 1','type':'delivery_note'},'ai_template':{'id':333,'name':'FT Accompagnatoria 1','type':'accompanying_invoice'},'notes':'','withholding_tax_taxable':100.0,'use_gross_prices':false,'payment_method':{'id':123321,'name':'Bonifico bancario','is_default':true,'details':[{'title':'Banca','description':'Indesa'},{'title':'IBAN','description':'IT17QA12345600000003498936'},{'title':'Intestatario','description':'Mario Rossi'}],'bank_iban':'IT17QA12345600000003498936','bank_name':'Indesa','bank_beneficiary':'Mario Rossi','ei_payment_method':'MP05'}},'extra_data_default_values':{'ts_communication':false,'ts_tipo_spesa':'SR','ts_pagamento_tracciato':false},'items_default_values':{'vat':{'value':22.0,'description':'','notes':'','e_invoice':true,'ei_type':'0','ei_description':'','is_disabled':false}},'countries_list':['Italia','Afghanistan','Albania','Algeria','Andorra','Angola','Anguilla','Antartide','Antigua e Barbuda','Antille Olandesi','Arabia Saudita','Argentina','Armenia','Aruba','Australia','Austria','Azerbaigian','Bahamas','Bahrain','Bangladesh','Barbados','Belgio','Belize','Benin','Bermuda','Bhutan','Bielorussia','Bolivia','Bosnia ed Erzegovina','Botswana','Brasile','Brunei','Bulgaria','Burkina Faso','Burundi','Cambogia','Camerun','Canada','Capo Verde','Ciad','Cile','Cina','Cipro','Citt\u00e0 del Vaticano','Colombia','Comore','Corea del Nord','Corea del Sud','Costa Rica','Costa d Avorio','Croazia','Cuba','Danimarca','Dominica','Ecuador','Egitto','El Salvador','Emirati Arabi Uniti','Eritrea','Estonia','Etiopia','Fiji','Filippine','Finlandia','Francia','Gabon','Gambia','Georgia','Georgia del Sud e isole Sandwich','Germania','Ghana','Giamaica','Giappone','Gibilterra','Gibuti','Giordania','Grecia','Grenada','Groenlandia','Guadalupa','Guam','Guatemala','Guernsey - Channel Islands','Guinea','Guinea Equatoriale','Guinea-Bissau','Guyana','Guyana Francese','Haiti','Heard Island e McDonald Islands','Honduras','Hong Kong','India','Indonesia','Iran','Iraq','Irlanda','Islanda','Isola Bouvet','Isola Christmas','Isola di Man','Isola Norfolk','Isole Canarie (Spagna)','Isole Cayman','Isole Cocos e Keeling','Isole Cook','Isole Falkland','Isole F\u00e6r \u00d8er','Isole Marianne Settentrionali','Isole Marshall','Isole Minori Esterne degli USA','Isole Pitcairn','Isole Salomone','Isole Vergini Americane','Isole Vergini Britanniche','Isole \u00c5land','Israele','Jersey - Channel Islands','Kazakistan','Kenia','Kirghizistan','Kiribati','Kosovo','Kuwait','Laos','Lesotho','Lettonia','Libano','Liberia','Libia','Liechtenstein','Lituania','Lussemburgo','Macao','Macedonia','Macedonia del Nord','Madagascar','Malawi','Malaysia','Maldive','Mali','Malta','Marocco','Martinica','Mauritania','Mauritius','Mayotte','Messico','Micronesia','Moldavia','Monaco','Mongolia','Montenegro','Montserrat','Mozambico','Myanmar','Namibia','Nauru','Nepal','Nicaragua','Niger','Nigeria','Niue','Norvegia','Nuova Caledonia','Nuova Zelanda','Oman','Paesi Bassi','Pakistan','Palau','Panama','Papua Nuova Guinea','Paraguay','Per\u00f9','Polinesia Francese','Polonia','Porto Rico','Portogallo','Qatar','Regno Unito','Repubblica Ceca','Repubblica Centrafricana','Repubblica Democratica del Congo','Repubblica Dominicana','Repubblica del Congo','Riunione','Romania','Ruanda','Russia','Sahara Occidentale','Saint Barthelemy','Saint Kitts e Nevis','Saint Pierre e Miquelon','Saint Vincent e Grenadine','Samoa','Samoa Americane','San Marino','Sant Elena','Santa Lucia','Senegal','Serbia','Seychelles','Sierra Leone','Singapore','Siria','Slovacchia','Slovenia','Somalia','Spagna','Sri Lanka','Stato di Palestina','Stati Uniti','Sudafrica','Sud Sudan','Sudan','Suriname','Svalbard e Jan Mayen','Svezia','Svizzera','Swaziland','S\u00e3o Tom\u00e9 e Pr\u00edncipe','Tagikistan','Taiwan','Tanzania','Terre australi e ant. francesi','Terr. Britannico dell Oc. Ind.','Thailandia','Timor Est','Togo','Tokelau','Tonga','Trinidad e Tobago','Tunisia','Turchia','Turkmenistan','Turks e Caicos','Tuvalu','Ucraina','Uganda','Ungheria','Uruguay','Uzbekistan','Vanuatu','Venezuela','Vietnam','Wallis e Futuna','Yemen','Zambia','Zimbabwe'],'currencies_list':[{'id':'AED','symbol':'AED','exchange_rate':'4.09500','html_symbol':'AED'},{'id':'ALL','symbol':'ALL','exchange_rate':'121.50000','html_symbol':'ALL'},{'id':'AUD','symbol':'AUD','exchange_rate':'1.62094','html_symbol':'AUD'},{'id':'AZN','symbol':'AZN','exchange_rate':'2.00130','html_symbol':'AZN'},{'id':'BGN','symbol':'\u043b\u0432','exchange_rate':'1.95583','html_symbol':'BGN'},{'id':'BRL','symbol':'R$','exchange_rate':'4.50410','html_symbol':'R$'},{'id':'BYN','symbol':'BYN','exchange_rate':'2.41000','html_symbol':'BYN'},{'id':'CAD','symbol':'CAD','exchange_rate':'1.49841','html_symbol':'CAD'},{'id':'CFA','symbol':'CFA','exchange_rate':'656.68000','html_symbol':'CFA'},{'id':'CHF','symbol':'Fr.','exchange_rate':'1.12559','html_symbol':'Fr.'},{'id':'CNY','symbol':'CNY','exchange_rate':'7.70160','html_symbol':'CNY'},{'id':'CRC','symbol':'\u20a1','exchange_rate':'659.17000','html_symbol':'\u20a1'},{'id':'CZK','symbol':'K\u010d','exchange_rate':'25.80600','html_symbol':'CZK'},{'id':'DKK','symbol':'kr.','exchange_rate':'7.46750','html_symbol':'kr.'},{'id':'DOP','symbol':'DOP','exchange_rate':'56.50000','html_symbol':'DOP'},{'id':'DZD','symbol':'DZD','exchange_rate':'134.28300','html_symbol':'DZD'},{'id':'EGP','symbol':'EGP','exchange_rate':'18.98030','html_symbol':'EGP'},{'id':'EUR','symbol':'\u20ac','exchange_rate':'1.00000','html_symbol':'\u20ac'},{'id':'GBP','symbol':'\u00a3','exchange_rate':'0.88096','html_symbol':'\u00a3'},{'id':'GHS','symbol':'GHS','exchange_rate':'5.45834','html_symbol':'GHS'},{'id':'HKD','symbol':'HK$','exchange_rate':'8.75450','html_symbol':'HK$'},{'id':'HRK','symbol':'HRK','exchange_rate':'7.42640','html_symbol':'HRK'},{'id':'HUF','symbol':'HUF','exchange_rate':'326.24000','html_symbol':'HUF'},{'id':'ILS','symbol':'\u20aa','exchange_rate':'4.02680','html_symbol':'\u20aa'},{'id':'INR','symbol':'INR','exchange_rate':'77.76050','html_symbol':'INR'},{'id':'ISK','symbol':'ISK','exchange_rate':'135.94600','html_symbol':'ISK'},{'id':'JPY','symbol':'\u00a5','exchange_rate':'123.05800','html_symbol':'\u00a5'},{'id':'KRW','symbol':'KRW','exchange_rate':'1329.20000','html_symbol':'KRW'},{'id':'MAD','symbol':'MAD','exchange_rate':'10.78900','html_symbol':'MAD'},{'id':'MKD','symbol':'MKD','exchange_rate':'61.36700','html_symbol':'MKD'},{'id':'MXN','symbol':'Mex$','exchange_rate':'21.17900','html_symbol':'Mex$'},{'id':'MYR','symbol':'MYR','exchange_rate':'4.67310','html_symbol':'MYR'},{'id':'NGN','symbol':'NGN','exchange_rate':'405.17000','html_symbol':'NGN'},{'id':'NIS','symbol':'NIS','exchange_rate':'4020.00000','html_symbol':'NIS'},{'id':'NOK','symbol':'kr','exchange_rate':'9.76270','html_symbol':'kr'},{'id':'NZD','symbol':'NZD','exchange_rate':'1.71687','html_symbol':'NZD'},{'id':'OMR','symbol':'OMR','exchange_rate':'0.42950','html_symbol':'OMR'},{'id':'PEN','symbol':'PEN','exchange_rate':'3.73400','html_symbol':'PEN'},{'id':'PLN','symbol':'z\u0142','exchange_rate':'4.30330','html_symbol':'PLN'},{'id':'QAR','symbol':'QAR','exchange_rate':'4.06270','html_symbol':'QAR'},{'id':'RON','symbol':'RON','exchange_rate':'4.66891','html_symbol':'RON'},{'id':'RSD','symbol':'RSD','exchange_rate':'117.39414','html_symbol':'RSD'},{'id':'RUB','symbol':'\u20bd','exchange_rate':'71.70370','html_symbol':'\u20bd'},{'id':'SAR','symbol':'SAR','exchange_rate':'4.18520','html_symbol':'SAR'},{'id':'SEK','symbol':'SEK','exchange_rate':'10.73374','html_symbol':'SEK'},{'id':'SGD','symbol':'SGD','exchange_rate':'1.53800','html_symbol':'SGD'},{'id':'THB','symbol':'THB','exchange_rate':'35.56400','html_symbol':'THB'},{'id':'TND','symbol':'TND','exchange_rate':'3.34010','html_symbol':'TND'},{'id':'TRY','symbol':'TRY','exchange_rate':'6.81590','html_symbol':'TRY'},{'id':'TWD','symbol':'TWD','exchange_rate':'35.14200','html_symbol':'TWD'},{'id':'UAH','symbol':'UAH','exchange_rate':'29.31490','html_symbol':'UAH'},{'id':'USD','symbol':'$','exchange_rate':'1.11570','html_symbol':'$'},{'id':'VND','symbol':'\u20ab','exchange_rate':'26100.00000','html_symbol':'\u20ab'},{'id':'ZAR','symbol':'R','exchange_rate':'16.03080','html_symbol':'R'}],'templates_list':[{'id':10,'name':'New Standard S1'},{'id':11,'name':'New Standard S2'},{'id':12,'name':'New Professionisti P1'},{'id':13,'name':'New Buste'},{'id':14,'name':'New Professionisti P2'},{'id':101,'name':'Clear lines'},{'id':106,'name':'Minimalist'},{'id':107,'name':'Squared'},{'id':108,'name':'Modern'},{'id':150,'name':'Bright Colors'},{'id':681,'name':'Modern Spese di trasporto'},{'id':682,'name':'Modern ciao'},{'id':2821,'name':'Light Smoke'},{'id':2823,'name':'IDEAVERDE'},{'id':2824,'name':'LS problem'},{'id':2825,'name':'Light Smoke 2nd CASSA'},{'id':2826,'name':'LIGHT NUOVO'},{'id':2827,'name':'STAND'}],'dn_templates_list':[{'id':660,'name':'DDT 1'},{'id':680,'name':'DDT Prova'}],'ai_templates_list':[{'id':663,'name':'FT Accompagnatoria 1'}],'payment_methods_list':[{'id':555,'name':'Rimessa diretta','is_default':false,'details':[]},{'id':123321,'name':'Bonifico bancario','is_default':true,'details':[{'title':'Banca','description':'Indesa'},{'title':'IBAN','description':'IT17QA12345600000003498936'},{'title':'Intestatario','description':'Mario Rossi'}],'bank_iban':'IT17QA12345600000003498936','bank_name':'Indesa','bank_beneficiary':'Mario Rossi','ei_payment_method':'MP05'}],'payment_accounts_list':[{'id':21,'name':'Indesa - Carta conto','virtual':false},{'id':287,'name':'Bonifico_Bancario','virtual':false}],'vat_types_list':[{'id':1409,'value':15.0,'description':'ALIQUOTA #1234#','e_invoice':false,'ei_type':'0','is_disabled':false},{'id':1332,'description':'Non imp. art. 17 c. 6 lett. A TER DPR 633/72','e_invoice':false,'ei_type':'0','is_disabled':false}]}}";
            var getIssuedDocumentPreCreateInfoResponse = JsonConvert.DeserializeObject<GetIssuedDocumentPreCreateInfoResponse>(getIssuedDocumentPreCreateInfoResponseBody);
            instance
                .Setup(p => p.GetIssuedDocumentPreCreateInfo(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), 0))
                .Returns(getIssuedDocumentPreCreateInfoResponse);

            getNewIssuedDocumentTotalsResponseBody = "{ 'data': { 'amount_net': 68.18, 'amount_rivalsa': 13.64, 'amount_net_with_rivalsa': 81.82, 'taxable_amount': 81.82, 'amount_vat': 8.18, 'amount_gross': 90.0, 'amount_due': 90.0, 'is_enasarco_maximal_exceeded': false, 'payments_sum': 75.0, 'vat_list': {} }}";
            var getNewIssuedDocumentTotalsResponse = JsonConvert.DeserializeObject<GetNewIssuedDocumentTotalsResponse>(getNewIssuedDocumentTotalsResponseBody);
            instance
                .Setup(p => p.GetNewIssuedDocumentTotals(Moq.It.IsAny<int>(), Moq.It.IsAny<GetNewIssuedDocumentTotalsRequest>(), 0))
                .Returns(getNewIssuedDocumentTotalsResponse);

            listIssuedDocumentsResponseBody = "{ 'current_page': 1, 'first_page_url': 'page=1', 'from': 1, 'last_page': 1, 'last_page_url': 'page=1', 'path': 'issued_documents', 'per_page': 50, 'to': 2, 'total': 2, 'data': [ { 'type': 'receipt', 'id': 12345, 'number': 1, 'numeration': 'rec123', 'date': '2021-08-20', 'subject': '', 'visible_subject': '', 'use_split_payment': false, 'use_gross_prices': false, 'e_invoice': false, 'show_payments': false, 'show_payment_method': false, 'show_paypal_button': false, 'show_notification_button': false, 'delivery_note': false, 'accompanying_invoice': false, 'is_marked': false, 'next_due_date': '2021-12-31', 'url': 'ypbqqe4u8w8bdabcd5fd5b1a4gtqhlof.pdf' }, { 'type': 'receipt', 'id': 12346, 'number': 1, 'numeration': 'rec124', 'date': '2021-08-28', 'subject': '', 'visible_subject': '', 'use_split_payment': false, 'use_gross_prices': false, 'e_invoice': false, 'show_payments': false, 'show_payment_method': false, 'show_paypal_button': false, 'show_notification_button': false, 'delivery_note': false, 'accompanying_invoice': false, 'is_marked': false, 'next_due_date': '2021-12-31', 'url': 'qwertye4u8w8bdaqrt5fd5b1a4gtqhlof.pdf' } ]}";
            var listIssuedDocumentsResponse = JsonConvert.DeserializeObject<ListIssuedDocumentsResponse>(listIssuedDocumentsResponseBody);
            instance
                .Setup(p => p.ListIssuedDocuments(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int?>(), Moq.It.IsAny<int?>(), Moq.It.IsAny<string>(), 0))
                .Returns(listIssuedDocumentsResponse);

            modifyIssuedDocumentResponseBody = "{ 'data': { 'type': 'receipt', 'show_totals': 'all', 'id': 12345, 'number': 1, 'numeration': 'rec123', 'date': '2021-08-20', 'year': 2021, 'currency': { 'id': 'EUR', 'symbol': '€', 'exchange_rate': '1.00000' }, 'language': { 'code': 'it', 'name': 'Italiano' }, 'subject': '', 'visible_subject': '', 'rc_center': '', 'notes': '', 'withholding_tax_taxable': 100.0, 'payment_method': { 'id': 4, 'name': 'Credit card', 'is_default': false, }, 'use_split_payment': false, 'use_gross_prices': false, 'e_invoice': false, 'items_list': [ { 'product_id': 5432, 'code': 'SG3', 'name': 'Soggiorno', 'description': '', 'qty': 1.0, 'measure': '', 'net_price': 68.18182, 'gross_price': 75.0, 'vat': { 'id': 3, 'value': 10.0, 'description': '', 'e_invoice': false, 'is_disabled': false }, 'not_taxable': false, 'apply_withholding_taxes': true, 'discount_highlight': false, 'in_ddt': false, 'stock': false } ], 'payments_list': [ { 'status': 'not_paid', 'due_date': '2020-08-23', 'amount': 75.0, 'paid_date': '2020-08-23' } ], 'template': { 'id': 2821, 'name': 'Light Smoke' }, 'h_margins': 15, 'v_margins': 16, 'show_payments': true, 'show_payment_method': false, 'show_paypal_button': true, 'show_notification_button': false, 'show_tspay_button': false, 'delivery_note': false, 'accompanying_invoice': false, 'is_marked': false, 'next_due_date': '2020-08-23', 'url': 'y12h45rn9yf2mse0p43t7ec90vr.pdf' } }";
            var modifyIssuedDocumentResponse = JsonConvert.DeserializeObject<ModifyIssuedDocumentResponse>(modifyIssuedDocumentResponseBody);
            instance
                .Setup(p => p.ModifyIssuedDocument(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<ModifyIssuedDocumentRequest>(), 0))
                .Returns(modifyIssuedDocumentResponse);

            uploadIssuedDocumentAttachmentResponseBody = "{'data':{'attachment_token':'YmMyNWYxYzIwMTU3N2Y4ZGE3ZjZiMzg5OWY0ODNkZDQveXl5LmRvYw'}}";
            var uploadIssuedDocumentAttachmentResponse = JsonConvert.DeserializeObject<UploadIssuedDocumentAttachmentResponse>(uploadIssuedDocumentAttachmentResponseBody);
            instance
                .Setup(p => p.UploadIssuedDocumentAttachment(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Stream>(), 0))
                .Returns(uploadIssuedDocumentAttachmentResponse);

            transformIssuedDocumentResponseBody = "{ 'data': { 'type': 'receipt', 'show_totals': 'all', 'id': 12345, 'entity': { 'id': 54321, 'name': 'Mary Red S.r.L.', 'vat_number': 'IT05432181211', 'tax_code': 'IT05432181211', 'address_street': 'Corso impero, 66', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'certified_email': 'mary@pec.red.com', 'ei_code': 'ABCXCR1' }, 'number': 1, 'numeration': 'rec123', 'date': '2021-08-20', 'year': 2021, 'currency': { 'id': 'EUR', 'symbol': '€', 'exchange_rate': '1.00000' }, 'language': { 'code': 'it', 'name': 'Italiano' }, 'subject': '', 'visible_subject': '', 'rc_center': '', 'notes': '', 'rivalsa': 0.0, 'cassa': 0.0, 'amount_cassa_taxable': 3.0, 'amount_cassa2_taxable': 3.0, 'amount_global_cassa_taxable': 3.0, 'withholding_tax': 0.0, 'withholding_tax_taxable': 100.0, 'other_withholding_tax': 0.0, 'stamp_duty': 0.0, 'payment_method': { 'id': 4, 'name': 'Credit card' }, 'use_split_payment': false, 'use_gross_prices': false, 'e_invoice': false, 'ei_data': { 'bank_name': 'Sao Paulo' }, 'ei_cassa_type': '', 'ei_cassa2_type': '3', 'ei_withholding_tax_causal': 'a', 'ei_other_withholding_tax_type': 'a', 'ei_other_withholding_tax_causal': 'c', 'items_list': [ { 'id': 277876033, 'product_id': 5432, 'code': 'SG3', 'name': 'Soggiorno', 'category': '', 'description': '', 'qty': 1.0, 'measure': '', 'net_price': 68.18182, 'gross_price': 75.0, 'vat': { 'id': 3, 'value': 10.0, 'description': '' }, 'not_taxable': false, 'apply_withholding_taxes': true, 'discount': 0.0, 'discount_highlight': false, 'stock': false } ], 'payments_list': [ { 'status': 'not_paid', 'id': 69078013, 'due_date': '2020-08-23', 'amount': 75.0, 'payment_terms': { 'type': 'standard', 'days': 0 } } ], 'template': { 'id': 2821, 'name': 'Light Smoke' }, 'delivery_note_template': { 'id': 54321 }, 'acc_inv_template': { 'id': 4 }, 'h_margins': 15, 'v_margins': 16, 'show_payments': true, 'show_payment_method': false, 'show_paypal_button': true, 'show_notification_button': false, 'show_tspay_button': false, 'delivery_note': false, 'accompanying_invoice': false, 'dn_number': 3, 'dn_date': '2020-10-21', 'dn_ai_packages_number': '4', 'dn_ai_weight': '3', 'dn_ai_causal': 'causal', 'dn_ai_destination': 'dest', 'dn_ai_transporter': 'trasp', 'dn_ai_notes': 'notes', 'is_marked': false, 'amount_due_discount': 1.0, 'amount_rivalsa_taxable': 3.0, 'amount_withholding_tax_taxable': 3.0, 'amount_other_withholding_tax_taxable': 3.0, 'amount_enasarco_taxable': 3.0, 'extra_data': { 'ts_status': 1 }, 'seen_date': '2020-08-23', 'next_due_date': '2020-08-23', 'url': 'y12h45rn9yf2mse0p43t7ec90vr.pdf', 'attachment_token': 'asdaosdjaoisndoa', 'ei_raw': { 'prop': true } }, 'options': { 'create_from': [ '82112399' ], 'transform': true, 'keep_copy': true } }";
            var transformIssuedDocumentResponse = JsonConvert.DeserializeObject<TransformIssuedDocumentResponse>(transformIssuedDocumentResponseBody);
            instance
                .Setup(p => p.TransformIssuedDocument(Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), 0))
                .Returns(transformIssuedDocumentResponse);

            joinIssuedDocumentsResponseBody = "{ 'data': { 'type': 'receipt', 'show_totals': 'all', 'id': 12345, 'entity': { 'id': 54321, 'name': 'Mary Red S.r.L.', 'vat_number': 'IT05432181211', 'tax_code': 'IT05432181211', 'address_street': 'Corso impero, 66', 'address_postal_code': '20900', 'address_city': 'Milano', 'address_province': 'MI', 'address_extra': '', 'country': 'Italia', 'certified_email': 'mary@pec.red.com', 'ei_code': 'ABCXCR1' }, 'number': 1, 'numeration': 'rec123', 'date': '2021-08-20', 'year': 2021, 'currency': { 'id': 'EUR', 'symbol': '€', 'exchange_rate': '1.00000' }, 'language': { 'code': 'it', 'name': 'Italiano' }, 'subject': '', 'visible_subject': '', 'rc_center': '', 'notes': '', 'rivalsa': 0.0, 'cassa': 0.0, 'amount_cassa_taxable': 3.0, 'amount_cassa2_taxable': 3.0, 'amount_global_cassa_taxable': 3.0, 'withholding_tax': 0.0, 'withholding_tax_taxable': 100.0, 'other_withholding_tax': 0.0, 'stamp_duty': 0.0, 'payment_method': { 'id': 4, 'name': 'Credit card' }, 'use_split_payment': false, 'use_gross_prices': false, 'e_invoice': false, 'ei_data': { 'bank_name': 'Sao Paulo' }, 'ei_cassa_type': '', 'ei_cassa2_type': '3', 'ei_withholding_tax_causal': 'a', 'ei_other_withholding_tax_type': 'a', 'ei_other_withholding_tax_causal': 'c', 'items_list': [ { 'id': 277876033, 'product_id': 5432, 'code': 'SG3', 'name': 'Soggiorno', 'category': '', 'description': '', 'qty': 1.0, 'measure': '', 'net_price': 68.18182, 'gross_price': 75.0, 'vat': { 'id': 3, 'value': 10.0, 'description': '' }, 'not_taxable': false, 'apply_withholding_taxes': true, 'discount': 0.0, 'discount_highlight': false, 'stock': false } ], 'payments_list': [ { 'status': 'not_paid', 'id': 69078013, 'due_date': '2020-08-23', 'amount': 75.0, 'payment_terms': { 'type': 'standard', 'days': 0 } } ], 'template': { 'id': 2821, 'name': 'Light Smoke' }, 'delivery_note_template': { 'id': 54321 }, 'acc_inv_template': { 'id': 4 }, 'h_margins': 15, 'v_margins': 16, 'show_payments': true, 'show_payment_method': false, 'show_paypal_button': true, 'show_notification_button': false, 'show_tspay_button': false, 'delivery_note': false, 'accompanying_invoice': false, 'dn_number': 3, 'dn_date': '2020-10-21', 'dn_ai_packages_number': '4', 'dn_ai_weight': '3', 'dn_ai_causal': 'causal', 'dn_ai_destination': 'dest', 'dn_ai_transporter': 'trasp', 'dn_ai_notes': 'notes', 'is_marked': false, 'amount_due_discount': 1.0, 'amount_rivalsa_taxable': 3.0, 'amount_withholding_tax_taxable': 3.0, 'amount_other_withholding_tax_taxable': 3.0, 'amount_enasarco_taxable': 3.0, 'extra_data': { 'ts_status': 1 }, 'seen_date': '2020-08-23', 'next_due_date': '2020-08-23', 'url': 'y12h45rn9yf2mse0p43t7ec90vr.pdf', 'attachment_token': 'asdaosdjaoisndoa', 'ei_raw': { 'prop': true } }, 'options': { 'create_from': [ '82112399', '82738223' ] } }";
            var joinIssuedDocumentsResponse = JsonConvert.DeserializeObject<JoinIssuedDocumentsResponse>(joinIssuedDocumentsResponseBody);
            instance
                .Setup(p => p.JoinIssuedDocuments(Moq.It.IsAny<int>(), Moq.It.IsAny<string>(), Moq.It.IsAny<int>(), Moq.It.IsAny<int>(), 0))
                .Returns(joinIssuedDocumentsResponse);

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IssuedDocumentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<Mock<IIssuedDocumentsApi>>(instance);
        }

        /// <summary>
        /// Test CreateIssuedDocument
        /// </summary>
        [Fact]
        public void CreateIssuedDocumentTest()
        {
            int companyId = 2;
            CreateIssuedDocumentRequest createIssuedDocumentRequest = new CreateIssuedDocumentRequest();

            var response = instance.Object.CreateIssuedDocument(companyId, createIssuedDocumentRequest);
            JObject obj = JObject.Parse(createIssuedDocumentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test DeleteIssuedDocument
        /// </summary>
        [Fact]
        public void DeleteIssuedDocumentTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test DeleteIssuedDocumentAttachment
        /// </summary>
        [Fact]
        public void DeleteIssuedDocumentAttachmentTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test GetEmailData
        /// </summary>
        [Fact]
        public void GetEmailDataTest()
        {
            int companyId = 2;
            int documentId = 12345;

            var response = instance.Object.GetEmailData(companyId, documentId);
            JObject obj = JObject.Parse(getEmailDataResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test GetExistingIssuedDocumentTotals
        /// </summary>
        [Fact]
        public void GetExistingIssuedDocumentTotalsTest()
        {
            int companyId = 2;
            int documentId = 12345;

            GetExistingIssuedDocumentTotalsRequest getExistingIssuedDocumentTotalsRequest = new GetExistingIssuedDocumentTotalsRequest();

            var response = instance.Object.GetExistingIssuedDocumentTotals(companyId, documentId, getExistingIssuedDocumentTotalsRequest);
            JObject obj = JObject.Parse(getExistingIssuedDocumentTotalsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test GetIssuedDocument
        /// </summary>
        [Fact]
        public void GetIssuedDocumentTest()
        {
            int companyId = 2;
            int documentId = 12345;
            string fields = "";
            string fieldset = "";

            var response = instance.Object.GetIssuedDocument(companyId, documentId, fields, fieldset);
            JObject obj = JObject.Parse(getIssuedDocumentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test GetIssuedDocumentPreCreateInfo
        /// </summary>
        [Fact]
        public void GetIssuedDocumentPreCreateInfoTest()
        {
            int companyId = 2;
            string type = "";

            var response = instance.Object.GetIssuedDocumentPreCreateInfo(companyId, type);
            JObject obj = JObject.Parse(getIssuedDocumentPreCreateInfoResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test GetNewIssuedDocumentTotals
        /// </summary>
        [Fact]
        public void GetNewIssuedDocumentTotalsTest()
        {
            int companyId = 2;
            GetNewIssuedDocumentTotalsRequest getNewIssuedDocumentTotalsRequest = new GetNewIssuedDocumentTotalsRequest();

            var response = instance.Object.GetNewIssuedDocumentTotals(companyId, getNewIssuedDocumentTotalsRequest);
            JObject obj = JObject.Parse(getNewIssuedDocumentTotalsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ListIssuedDocuments
        /// </summary>
        [Fact]
        public void ListIssuedDocumentsTest()
        {
            int companyId = 2;
            string type = "";
            string fields = "";
            string fieldset = "";
            string sort = "";
            int? page = 15;
            int? perPage = 5;

            var response = instance.Object.ListIssuedDocuments(companyId, type, fields, fieldset, sort, page, perPage);
            JObject obj = JObject.Parse(listIssuedDocumentsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ModifyIssuedDocument
        /// </summary>
        [Fact]
        public void ModifyIssuedDocumentTest()
        {
            int companyId = 2;
            int documentId = 12345;
            ModifyIssuedDocumentRequest modifyIssuedDocumentRequest = new ModifyIssuedDocumentRequest();

            var response = instance.Object.ModifyIssuedDocument(companyId, documentId, modifyIssuedDocumentRequest);
            JObject obj = JObject.Parse(modifyIssuedDocumentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test ScheduleEmail
        /// </summary>
        [Fact]
        public void ScheduleEmailTest()
        {
            Assert.True(true);
        }

        /// <summary>
        /// Test UploadIssuedDocumentAttachment
        /// </summary>
        [Fact]
        public void UploadIssuedDocumentAttachmentTest()
        {
            int companyId = 2;
            string filename = "";
            Stream attachment = new MemoryStream();

            var response = instance.Object.UploadIssuedDocumentAttachment(companyId, filename, attachment);
            JObject obj = JObject.Parse(uploadIssuedDocumentAttachmentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test TransformIssuedDocument
        /// </summary>
        [Fact]
        public void TransformIssuedDocumentTest()
        {
            int companyId = 2;

            var response = instance.Object.TransformIssuedDocument(companyId, 54321, "proforma", 1, 1);
            JObject obj = JObject.Parse(transformIssuedDocumentResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }

        /// <summary>
        /// Test JoinIssuedDocuments
        /// </summary>
        [Fact]
        public void JoinIssuedDocumentTest()
        {
            int companyId = 2;

            var response = instance.Object.JoinIssuedDocuments(companyId, "5432,6789", 1, 1);
            JObject obj = JObject.Parse(joinIssuedDocumentsResponseBody);

            Assert.True(JToken.DeepEquals(obj, JObject.FromObject(response)));
        }
    }
}
