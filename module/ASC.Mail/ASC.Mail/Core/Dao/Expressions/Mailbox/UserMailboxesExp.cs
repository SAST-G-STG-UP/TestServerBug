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


using ASC.Common.Data.Sql.Expressions;
using ASC.Mail.Core.DbSchema.Tables;

namespace ASC.Mail.Core.Dao.Expressions.Mailbox
{
    public class UserMailboxesExp : TenantMailboxesExp
    {
        private readonly string _user;
        private readonly bool? _onlyTeamlab;

        public UserMailboxesExp(int tenant, string user, bool? isRemoved = false, bool? onlyTeamlab = null)
            : base(tenant, isRemoved)
        {
            _user = user;
            _onlyTeamlab = onlyTeamlab;
        }

        public override Exp GetExpression()
        {
            var exp = base.GetExpression();

            exp = exp & Exp.Eq(MailboxTable.Columns.User, _user);

            if (_onlyTeamlab.HasValue)
            {
                exp = exp & Exp.Eq(MailboxTable.Columns.IsServerMailbox, _onlyTeamlab.Value);
            }

            return exp;
        }
    }
}