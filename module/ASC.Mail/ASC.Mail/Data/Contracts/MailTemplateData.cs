/*
 *
 * (c) Copyright Ascensio System Limited 2010-2023
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/


using System.Collections.Generic;

using ASC.Mail.Data.Contracts.Base;
using ASC.Mail.Enums;

namespace ASC.Mail.Data.Contracts
{
    public class MailTemplateData : MailComposeBase
    {
        public MailTemplateData(int id, MailBoxData mailBoxData, string from, List<string> to, List<string> cc,
            List<string> bcc,
            string subject, string mimeMessageId, string mimeReplyToId, bool important,
            List<int> tags, string body, string streamId, List<MailAttachmentData> attachments, string calendarIcs = "")
            : base(
                id, mailBoxData, FolderType.Templates, from, to, cc, bcc, subject, mimeMessageId, mimeReplyToId, important,
                tags, body, streamId, attachments, calendarIcs)
        {
        }
    }
}