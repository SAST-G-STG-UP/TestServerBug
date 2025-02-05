﻿/*
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

namespace ASC.Mail.Core.Entities
{
    public class CashedMailUserAction
    {
        public string UserName { get; set; }
        public int Tenant { get; set; }
        public List<int> Uds { get; set; }
        public MailUserAction Action { get; set; }
        public int Destination { get; set; }
        public string Data { get; set; }
        public uint? UserFolderId  { get; set; }
    }

    public enum MailUserAction
    {
        Nothing,
        SetAsRead,
        SetAsUnread,
        SetAsImportant,
        SetAsNotImpotant,
        SetAsDeleted,
        StartImapClient,
        MoveTo,
        ReceiptStatusChanged,
        Restore,
        CreateFolder,
        UpdateDrafts,
        SendDraft,
        DeleteUserFolder,
        UpdateUserFolder,
        MessageUidlUpdate
    }
}
