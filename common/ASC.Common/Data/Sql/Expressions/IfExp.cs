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

namespace ASC.Common.Data.Sql.Expressions
{
    public class IfExp : Exp
    {
        private readonly ISqlInstruction _condition;
        private readonly object _trueValue;
        private readonly object _falseValue;

        public IfExp(Exp condition, object trueValue, object falseValue)
        {
            _condition = condition;
            _trueValue = trueValue;
            _falseValue = falseValue;
        }

        public override string ToString(ISqlDialect dialect)
        {
            return string.Format("if({0}, ?, ?)", _condition.ToString(dialect));
        }

        public override IEnumerable<object> GetParameters()
        {
            var parameters = new List<object>();
            parameters.AddRange(_condition.GetParameters());
            parameters.AddRange(new[] { _trueValue, _falseValue });
            return parameters;
        }
    }
}