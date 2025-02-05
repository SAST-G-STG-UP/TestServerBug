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


ASC.UserQuotaController.PageNavigator = (function () {
    var pgNavigator, $totalUsers;

    var init = function () {
       // var resources = people.Resources;

        pgNavigator = new ASC.Controls.PageNavigator.init(
            "ASC.UserQuotaController.PageNavigator.pgNavigator",
            "#peoplePageNavigator",
            25,
            3,
            1,
            "Prev",
            "Next");

        pgNavigator.changePageCallback = function (page) {
            ASC.UserQuotaController.moveToPage(page);
        }

        function onRenderProfiles(evt, params) {
            var usersCount = params.__total || params.__count;
            pgNavigator.drawPageNavigator(params.page, usersCount);
            if (!$totalUsers) {
                $totalUsers = jq("#totalUsers");
            }
            $totalUsers.text(usersCount);
        }

        jq(window).on('people-render-profiles', onRenderProfiles);
    };

    return {
        init: init,
        get pgNavigator() {
            return pgNavigator;
        }
    }
})();


