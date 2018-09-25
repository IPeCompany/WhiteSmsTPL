using IPE.WhiteSmsTPL.RequestBodyModel.Contacts;
using IPE.WhiteSmsTPL.RequestBodyModel.DraftMessages;
using IPE.WhiteSmsTPL.RequestBodyModel.Messages;
using IPE.WhiteSmsTPL.RequestBodyModel.Shared;
using IPE.WhiteSmsTPL.RequestBodyModel.Token;
using IPE.WhiteSmsTPL.Responses;
using IPE.WhiteSmsTPL.Responses.BankTransaction;
using IPE.WhiteSmsTPL.Responses.Contacts;
using IPE.WhiteSmsTPL.Responses.DraftMessages;
using IPE.WhiteSmsTPL.Responses.FAQ;
using IPE.WhiteSmsTPL.Responses.Message;
using IPE.WhiteSmsTPL.Responses.Notifications;
using IPE.WhiteSmsTPL.Responses.OccasionalMessages;
using IPE.WhiteSmsTPL.Responses.Ticket;
using IPE.WhiteSmsTPL.Responses.Token;
using IPE.WhiteSmsTPL.Responses.WhiteSms;
using RestSharp;
using System;
using System.Linq;

namespace IPE.WhiteSmsTPL
{
    public partial class MethodHelper
    {
        private string _userApiKey;
        private string _secretKey;
        private RestClient _client;
        public MethodHelper(string userApiKey, string secretKey)
        {
            if (string.IsNullOrWhiteSpace(userApiKey))
                throw new ArgumentException("UserAPILKey is not valid!");

            if (string.IsNullOrWhiteSpace(secretKey))
                throw new ArgumentException("SecretKey is not valid!");

            _userApiKey = userApiKey;
            _secretKey = secretKey;
            _client = new RestClient();
        }

        #region Token

        //T
        public GetTokenResponse GetToken()
        {
            try
            {
                var uri = $@"https://api.sms.ir/users/v1/Token/GetToken";
                _client.BaseUrl = new Uri(uri);
                var body = new GetTokenBodyModel
                {
                    SecretKey = _secretKey,
                    UserApiKey = _userApiKey
                }.ToJson();
                var param = new Parameter { ContentType = "Body", Type = ParameterType.RequestBody, Value = body, Name = "undefined" };
                var request = new IPERequest(Method.POST, param);
                var response = _client.Execute(request);

                return response.GetContent<GetTokenResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        #endregion


        #region BankTransaction
        //T
        public GetBankTransaction GetBankTransactionsByPageId(string token, int pageId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/BankTransaction/GetBankTransactionsByPageId?pageid={pageId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetBankTransaction>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetBankTransaction GetBankTransactionsFromLastId(string token, int lastId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/BankTransaction/GetBankTransactionsFromLastId?lastid={lastId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetBankTransaction>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        #endregion


        #region Contacts
        //todo in response.EmojiId is null,fix it...
        public AddContactsResponse AddContacts(string token, ContactInfo model)
        {
            try
            {
                token.TokenValidation();

                if (model == null)
                    throw new ArgumentException("مدل را وارد کنید");

                if (model.ContactsDetails == null || !model.ContactsDetails.Any())
                    throw new ArgumentException("آرایه اطلاعات مخاطبین را پر نمایید");

                var uri = $@"https://api.sms.ir/users/v1/Contacts/AddContacts";
                _client.BaseUrl = new Uri(uri);

                var body = model.ToJson();

                var request = new IPERequest(Method.POST, token, body);
                var response = _client.Execute(request);
                return response.GetContent<AddContactsResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public AddOrUpdateContactGroupResponse AddOrUpdateContactGroup(string token, AddOrUpdateContactGroupBodyModel model)
        {
            try
            {
                token.TokenValidation();

                var uri = $@"https://api.sms.ir/users/v1/Contacts/AddOrUpdateContactGroup";
                _client.BaseUrl = new Uri(uri);

                var body = model.ToJson();

                var request = new IPERequest(Method.POST, token, body);
                var response = _client.Execute(request);
                return response.GetContent<AddOrUpdateContactGroupResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public BaseResponse DeleteContactGroup(string token, int groupId)
        {
            try
            {
                token.TokenValidation();

                var uri = $@"https://api.sms.ir/users/v1/Contacts/DeleteContactGroup?groupId={groupId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<BaseResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //todo api does not work!
        public BaseResponse DeleteContacts(string token, int[] ids)
        {
            try
            {
                token.TokenValidation();
                if (ids == null || !ids.Any())
                    throw new ArgumentException("آرایه شناسه مخاطبین را پر نمایید");

                var uri = $@"https://api.sms.ir/users/v1/Contacts/DeleteContacts";
                _client.BaseUrl = new Uri(uri);
                var obj = ids.ToJson();

                var request = new IPERequest(Method.POST, token, obj);
                var response = _client.Execute(request);
                return response.GetContent<BaseResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //todo api has error!"object reference null..."
        public BaseResponse DeleteGroupContacts(string token, int[] groupIds)
        {
            try
            {
                token.TokenValidation();

                if (groupIds == null || !groupIds.Any())
                    throw new ArgumentException("آرایه شناسه گروه‌ها را پر نمایید");

                var uri = $@"https://api.sms.ir/users/v1/Contacts/DeleteGroupContacts";
                _client.BaseUrl = new Uri(uri);
                var obj = groupIds.ToJson();

                var request = new IPERequest(Method.POST, token, obj);
                var response = _client.Execute(request);
                return response.GetContent<BaseResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetCancelledContactsByPageIdResponse GetCancelledContactsByPageId(string token, int pageId)
        {
            try
            {
                token.TokenValidation();

                var uri = $@"https://api.sms.ir/users/v1/Contacts/GetCancelledContactsByPageId?pageId=0";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetCancelledContactsByPageIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetContactGroupsResponse GetContactGroups(string token)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Contacts/GetContactGroups";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetContactGroupsResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //todo api returns creationdateTime null,fix it... 
        public GetContactsByPageIdResponse GetContactsByGroupIdByPageId(string token, int groupId, int pageId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Contacts/GetContactsByGroupIdByPageId?groupId={groupId}&pageid={pageId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetContactsByPageIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetContactsByPageIdResponse GetContactsByPageId(string token, int pageId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Contacts/GetContactsByPageId?pageId={pageId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetContactsByPageIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetContactsFromLastIdResponse GetContactsFromLastId(string token, int lastId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Contacts/GetContactsFromLastId?lastid={lastId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetContactsFromLastIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public SearchContactsResponse SearchContacts(string token, string prefix, string firstName, string lastName, string mobile, int groupId, int pageId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Contacts/SearchContacts?prefix={prefix}&firstname={firstName}&lastname={lastName}&mobile={mobile}&groupid={groupId}&pageid={pageId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<SearchContactsResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public TransferContactsToGroupResponse TransferContactsToGroup(string token, TransferContactsToGroupBodyModel model)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Contacts/TransferContactsToGroup";
                _client.BaseUrl = new Uri(uri);

                var body = model.ToJson();
                var request = new IPERequest(Method.POST, token, body);
                var response = _client.Execute(request);
                return response.GetContent<TransferContactsToGroupResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        #endregion


        #region DraftMessages

        //todo api has error "object reference null..."
        public AddOrUpdateDraftMessageResponse AddOrUpdateDraftMessage(string token, AddOrUpdateDraftMessageBodyModel model)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/DraftMessage/AddOrUpdateDraftMessage";
                _client.BaseUrl = new Uri(uri);

                var body = model.ToJson();

                var request = new IPERequest(Method.POST, token, body);
                var response = _client.Execute(request);
                return response.GetContent<AddOrUpdateDraftMessageResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public BaseResponse DeleteDraftMessage(string token, int id)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/DraftMessage/DeleteDraftMessage?id={id}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<BaseResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //todo api returns nothing...
        public GetDraftMessagesResponse GetDraftMessages(string token)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/DraftMessage/GetDraftMessages";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetDraftMessagesResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        #endregion


        #region FAQ

        //T
        public GetFrequentlyAskedQuestionsResponse GetFrequentlyAskedQuestions(string token)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/FrequentlyAskedQuestion/GetFrequentlyAskedQuestions";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetFrequentlyAskedQuestionsResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        #endregion


        #region Message

        //todo api returns null content and,document abount this method is not correct...
        public GetLastSentMessagesByPageIdResponse GetLastSentMessagesByPageId(string token, int pageId/*, ContactInfo model*/)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Message/GetLastSentMessagesByPageId?pageId={pageId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetLastSentMessagesByPageIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetLastSentMessagesFromLastIdResponse GetLastSentMessagesFromLastId(string token, int lastId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Message/GetLastSentMessagesFromLastId?lastId={lastId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetLastSentMessagesFromLastIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetSentMessagesMobileNumbersResponse GetSentMessagesMobileNumbers(string token, int lastId, string batchKey)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Message/GetSentMessagesMobileNumbers?lastId={lastId}&batchKey={batchKey}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetSentMessagesMobileNumbersResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //todo,in api, empty array does not accepted!wrong documentaton...
        public GroupContactsDistinctCountResponse GroupContactsDistinctCount(string token, GroupContactsDistinctCountBodyModel model)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Message/GroupContactsDistinctCount";
                _client.BaseUrl = new Uri(uri);

                var body = model.ToJson();

                var request = new IPERequest(Method.POST, token, body);
                var response = _client.Execute(request);
                return response.GetContent<GroupContactsDistinctCountResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public SendResponse Send(string token, SendBodyModel model)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Message/Send";
                _client.BaseUrl = new Uri(uri);

                var body = model.ToJson();

                var request = new IPERequest(Method.POST, token, body);
                var response = _client.Execute(request);
                return response.GetContent<SendResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //send has done but exception thrown,"object refrence null..."
        public SendResponse SendByMobileNumbers(string token, SendByMobileNumbersBodyModel model)
        {
            try
            {
                token.TokenValidation();
                if (model == null)
                    throw new ArgumentException("مدل ارسال را پر نمایید");

                if (string.IsNullOrWhiteSpace(model.Message))
                    throw new ArgumentException("متن پیام نمیتواند خالی باشد");

                if (model.MobileNumbers == null || !model.MobileNumbers.Any())
                    throw new ArgumentException("لیست شمارهمخاطبین نمیتواند خالی باشد");

                var uri = $@"https://api.sms.ir/users/v1/Message/SendByMobileNumbers";
                _client.BaseUrl = new Uri(uri);

                var body = model.ToJson();

                var request = new IPERequest(Method.POST, token, body);
                var response = _client.Execute(request);
                return response.GetContent<SendResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        #endregion


        #region Notification

        //T
        public GetNotificationResponse GetUserNotificationFromLastId(string token, int lastId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Notification/GetUserNotificationFromLastId?lastId={lastId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetNotificationResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetNotificationResponse GetUserNotificationFromPageId(string token, int pageId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Notification/GetUserNotificationFromPageId?pageId={pageId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute<GetNotificationResponse>(request);
                return response.GetContent<GetNotificationResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //todo I have not currect notif. id!
        public BaseResponse UpdateNotificationStatus(string token, int id)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Notification/UpdateNotificationStatus?id=0";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<BaseResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        #endregion


        #region OccasionalMessage

        //todo api has error!"obj reference..."
        public GetOccasionalMessageCategoryResponse GetOccasionalMessageCategory(string token)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/OccasionalMessage/GetOccasionalMessageCategory";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetOccasionalMessageCategoryResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //Todo recheck after fix above...
        public GetOccasionalMessagesResponse GetOccasionalMessages(string token, int occasionalMessageCategoryId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/OccasionalMessage/GetOccasionalMessages?occasionalMessageCategoryId={occasionalMessageCategoryId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetOccasionalMessagesResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        #endregion


        #region Ticket

        //T
        public BaseResponse CloseTicket(string token, int ticketId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Ticket/CloseTicket?ticketId={ticketId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<BaseResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetTicketByIdResponse GetTicketById(string token, int ticketId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Ticket/GetTicketById?ticketId={ticketId}";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetTicketByIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetTicketPrioritiesAndDepartmentsResponse GetTicketPrioritiesAndDepartments(string token)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Ticket/GetTicketPrioritiesAndDepartments";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetTicketPrioritiesAndDepartmentsResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetTicketStatusResponse GetTicketStatus(string token)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Ticket/GetTicketStatus";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetTicketStatusResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetTicketsByPageIdResponse GetTicketsByPageId(string token, int pageId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Ticket/GetTicketsByPageId?pageId={pageId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetTicketsByPageIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        //T
        public GetTicketsFromLastIdResponse GetTicketsFromLastId(string token, int lastId)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/Ticket/GetTicketsFromLastId?lastId={lastId}";
                _client.BaseUrl = new Uri(uri);
                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetTicketsFromLastIdResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        #endregion


        #region WhiteSms

        //T
        public GetUserInfoResponse GetUserInfo(string token)
        {
            try
            {
                token.TokenValidation();
                var uri = $@"https://api.sms.ir/users/v1/WhiteSms/GetUserInfo";
                _client.BaseUrl = new Uri(uri);

                var request = new IPERequest(Method.GET, token);
                var response = _client.Execute(request);
                return response.GetContent<GetUserInfoResponse>();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        #endregion
    }
}


