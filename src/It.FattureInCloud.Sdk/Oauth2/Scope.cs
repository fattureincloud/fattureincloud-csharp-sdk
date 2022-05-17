namespace It.FattureInCloud.Sdk.OauthHelper
{
    /// <summary>
    ///     Scope enum
    /// </summary>
    public enum Scope
    {
        /// <summary>Read permission to the Clients registry</summary>
        ENTITY_CLIENTS_READ,

        /// <summary>Write permission to the Clients registry</summary>
        ENTITY_CLIENTS_ALL,

        /// <summary>Read permission to the Suppliers registry</summary>
        ENTITY_SUPPLIERS_READ,

        /// <summary>Write permission to the Suppliers registry</summary>
        ENTITY_SUPPLIERS_ALL,

        /// <summary>Read permission to the Products</summary>
        PRODUCTS_READ,

        /// <summary>Write permission to the Products</summary>
        PRODUCTS_ALL,

        /// <summary>Read permission to the issued Invoices</summary>
        ISSUED_DOCUMENTS_INVOICES_READ,

        /// <summary>Read permission to the issued Credit Notes</summary>
        ISSUED_DOCUMENTS_CREDIT_NOTES_READ,

        /// <summary>Read permission to the issued Receipts</summary>
        ISSUED_DOCUMENTS_RECEIPTS_READ,

        /// <summary>Read permission to the issued Orders</summary>
        ISSUED_DOCUMENTS_ORDERS_READ,

        /// <summary>Read permission to the issued Quotes</summary>
        ISSUED_DOCUMENTS_QUOTES_READ,

        /// <summary>Read permission to the issued Proformas</summary>
        ISSUED_DOCUMENTS_PROFORMAS_READ,

        /// <summary>Read permission to the issued Delivery Notes</summary>
        ISSUED_DOCUMENTS_DELIVERY_NOTES_READ,

        /// <summary>Write permission to the issued Invoices</summary>
        ISSUED_DOCUMENTS_INVOICES_ALL,

        /// <summary>Write permission to the issued Credit Notes</summary>
        ISSUED_DOCUMENTS_CREDIT_NOTES_ALL,

        /// <summary>Write permission to the issued issued Receipts</summary>
        ISSUED_DOCUMENTS_RECEIPTS_ALL,

        /// <summary>Write permission to the issued Orders</summary>
        ISSUED_DOCUMENTS_ORDERS_ALL,

        /// <summary>Write permission to the issued Quotes</summary>
        ISSUED_DOCUMENTS_QUOTES_ALL,

        /// <summary>Write permission to the issued Proformas</summary>
        ISSUED_DOCUMENTS_PROFORMAS_ALL,

        /// <summary>Write permission to the issued Delivery Notes</summary>
        ISSUED_DOCUMENTS_DELIVERY_NOTES_ALL,

        /// <summary>Read permission to the Received Documents</summary>
        RECEIVED_DOCUMENTS_READ,

        /// <summary>Write permission to the Received Documents</summary>
        RECEIVED_DOCUMENTS_ALL,

        /// <summary>Read permission to the Stock movements</summary>
        STOCK_READ,

        /// <summary>Write permission to the Stock movements</summary>
        STOCK_ALL,

        /// <summary>Read permission to the Receipts</summary>
        RECEIPTS_READ,

        /// <summary>Write permission to the Receipts</summary>
        RECEIPTS_ALL,

        /// <summary>Read permission to the Taxes</summary>
        TAXES_READ,

        /// <summary>Write permission to the Taxes</summary>
        TAXES_ALL,

        /// <summary>Read permission to the Archive Documents</summary>
        ARCHIVE_READ,

        /// <summary>Read permission to the Archive Documents</summary>
        ARCHIVE_ALL,

        /// <summary>Read permission to the Cashbook</summary>
        CASHBOOK_READ,

        /// <summary>Write permission to the Cashbook</summary>
        CASHBOOK_ALL,

        /// <summary>Read permission to the Settings</summary>
        SETTINGS_READ,

        /// <summary>Write permission to the Settings</summary>
        SETTINGS_ALL,

        /// <summary>Read permission to the company Situation</summary>
        SITUATION_READ
    }

    /// <summary>
    ///     Scope Extensions Class
    /// </summary>
    public class ScopeExtensions
    {
        /// <summary>
        ///     Returns the Scope value.
        /// </summary>
        /// <param name="scope">Scope</param>
        public static string GetScopeValue(Scope scope)
        {
            string stringScope = string.Empty;
            switch (scope.ToString())
            {
                case "ENTITY_CLIENTS_READ":
                    stringScope = "entity.clients:r";
                    break;

                case "ENTITY_CLIENTS_ALL":
                    stringScope = "entity.clients:a";
                    break;

                case "ENTITY_SUPPLIERS_READ":
                    stringScope = "entity.suppliers:r";
                    break;

                case "ENTITY_SUPPLIERS_ALL":
                    stringScope = "entity.suppliers:a";
                    break;

                case "PRODUCTS_READ":
                    stringScope = "products:r";
                    break;

                case "PRODUCTS_ALL":
                    stringScope = "products:a";
                    break;

                case "ISSUED_DOCUMENTS_INVOICES_READ":
                    stringScope = "issued_documents.invoices:r";
                    break;

                case "ISSUED_DOCUMENTS_CREDIT_NOTES_READ":
                    stringScope = "issued_documents.credit_notes:r";
                    break;

                case "ISSUED_DOCUMENTS_RECEIPTS_READ":
                    stringScope = "issued_documents.receipts:r";
                    break;

                case "ISSUED_DOCUMENTS_ORDERS_READ":
                    stringScope = "issued_documents.orders:r";
                    break;

                case "ISSUED_DOCUMENTS_QUOTES_READ":
                    stringScope = "issued_documents.quotes:r";
                    break;

                case "ISSUED_DOCUMENTS_PROFORMAS_READ":
                    stringScope = "issued_documents.proformas:r";
                    break;

                case "ISSUED_DOCUMENTS_DELIVERY_NOTES_READ":
                    stringScope = "issued_documents.delivery_notes:r";
                    break;

                case "ISSUED_DOCUMENTS_INVOICES_ALL":
                    stringScope = "issued_documents.invoices:a";
                    break;

                case "ISSUED_DOCUMENTS_CREDIT_NOTES_ALL":
                    stringScope = "issued_documents.credit_notes:a";
                    break;

                case "ISSUED_DOCUMENTS_RECEIPTS_ALL":
                    stringScope = "issued_documents.receipts:a";
                    break;

                case "ISSUED_DOCUMENTS_ORDERS_ALL":
                    stringScope = "issued_documents.orders:a";
                    break;

                case "ISSUED_DOCUMENTS_QUOTES_ALL":
                    stringScope = "issued_documents.quotes:a";
                    break;

                case "ISSUED_DOCUMENTS_PROFORMAS_ALL":
                    stringScope = "issued_documents.proformas:a";
                    break;

                case "ISSUED_DOCUMENTS_DELIVERY_NOTES_ALL":
                    stringScope = "issued_documents.delivery_notes:a";
                    break;

                case "RECEIVED_DOCUMENTS_READ":
                    stringScope = "received_documents:r";
                    break;

                case "RECEIVED_DOCUMENTS_ALL":
                    stringScope = "received_documents:a";
                    break;

                case "STOCK_READ":
                    stringScope = "stock:r";
                    break;

                case "STOCK_ALL":
                    stringScope = "stock:a";
                    break;

                case "RECEIPTS_READ":
                    stringScope = "receipts:r";
                    break;

                case "RECEIPTS_ALL":
                    stringScope = "receipts:a";
                    break;

                case "TAXES_READ":
                    stringScope = "taxes:r";
                    break;

                case "TAXES_ALL":
                    stringScope = "taxes:a";
                    break;

                case "ARCHIVE_READ":
                    stringScope = "archive:r";
                    break;

                case "ARCHIVE_ALL":
                    stringScope = "archive:a";
                    break;

                case "CASHBOOK_READ":
                    stringScope = "cashbook:r";
                    break;

                case "CASHBOOK_ALL":
                    stringScope = "cashbook:a";
                    break;

                case "SETTINGS_READ":
                    stringScope = "settings:r";
                    break;

                case "SETTINGS_ALL":
                    stringScope = "settings:a";
                    break;

                case "SITUATION_READ":
                    stringScope = "situation:r";
                    break;
            }

            return stringScope;
        }
    }
}