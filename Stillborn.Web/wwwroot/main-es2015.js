(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./$$_lazy_route_resource lazy recursive":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/Components/side-bar/side-bar.component.html":
/*!***************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/Components/side-bar/side-bar.component.html ***!
  \***************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div>\r\n    <ul class=\"menu\">\r\n        <li class=\"menuLi logoLi\">\r\n            <a routerLink=\"/authorization\">\r\n                Stillborn\r\n            </a></li>\r\n        <li class=\"menuLi\">\r\n            <a routerLink=\"/user-profile/{{userId}}\">\r\n                <img src=\"../assets/Img/SideBarMenu/home.svg\" alt=\"Profile\" class=\"sideBarIcon\"/>\r\n                Профиль\r\n            </a></li>\r\n        <li class=\"menuLi\">\r\n            <a routerLink=\"/chat-rooms/{{userId}}\">\r\n                <img src=\"../assets/Img/SideBarMenu/chat.svg\" alt=\"Chat\" class=\"sideBarIcon\" />\r\n                Сообщения\r\n            </a></li>\r\n        <li class=\"menuLi\">\r\n            <a routerLink=\"/friends/{{userId}}\">\r\n                <img src=\"../assets/Img/SideBarMenu/user.svg\" alt=\"Profile\" class=\"sideBarIcon\"/>\r\n                Друзья\r\n            </a></li>\r\n        <li class=\"menuLi\">\r\n            <a routerLink=\"/groups/{{userId}}\">\r\n                <img src=\"../assets/Img/SideBarMenu/users.svg\" alt=\"Profile\" class=\"sideBarIcon\"/>\r\n                Сообщества\r\n            </a></li>\r\n        <li class=\"menuLi\">\r\n            <a routerLink=\"/photos/{{userId}}\">\r\n                <img src=\"../assets/Img/SideBarMenu/picture.svg\" alt=\"Profile\" class=\"sideBarIcon\"/>\r\n                Фотографии\r\n            </a></li>\r\n    </ul>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/Components/user-profile/user-profile.component.html":
/*!***********************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/Components/user-profile/user-profile.component.html ***!
  \***********************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"userProfileMainDiv\">\r\n    <div class=\"inl userAvatar col-md-4\">\r\n        <img src=\"../assets/Img/SideBarMenu/user.svg\" alt=\"Profile\" class=\"userAvatarImg\" />\r\n    </div>\r\n    <div class=\"inl userMainInfo col-md-8\">\r\n        <span class=\"userNickName\">{{ selectedUser.nickName }}</span><br />\r\n        <span>Пол: </span><span id=\"IsMan\">{{ selectedUser.isMan }}</span>\r\n        <div class=\"mediaButtons \">\r\n            <a routerLink=\"/photos/{{userId}}\" class=\"mediaButton col-md-4\">\r\n                <span class=\"mediaCount\">{{ selectedUser.photoCount }}</span><br>\r\n                <span>фотографии</span>\r\n            </a>\r\n            <a routerLink=\"/friends/{{userId}}\" class=\"mediaButton col-md-4\">\r\n                <span class=\"mediaCount\">{{ selectedUser.friendsCount }}</span><br>\r\n                <span>друзья</span>\r\n            </a>\r\n            <a routerLink=\"/followers/{{userId}}\" class=\"mediaButton col-md-4\" (click)=\"goToFollowers()\">\r\n                <span class=\"mediaCount\">{{ selectedUser.followerCount }}</span><br>\r\n                <span>подписчики</span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"wall col-md-12\">\r\n    <app-user-profile-posts [selectedUser]=\"selectedUser\" [isMayEdit]=\"isMayEdit\">\r\n    </app-user-profile-posts>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html":
/*!**************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html ***!
  \**************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"wrapper\">\r\n\t<div class=\"sideBar col-md-2\">\r\n\t\t<app-side-bar></app-side-bar>\r\n\t</div>\r\n\t<div class=\"content col-md-8\" id=\"content\">\r\n\t\t<router-outlet></router-outlet>\r\n\t</div>\r\n\t<div class=\"rightSideBar col-md-2\" id=\"rightSideBar\">\r\n\t\tДоп. контент\r\n\t</div>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/authorization/authorization.component.html":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/components/authorization/authorization.component.html ***!
  \*************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"authorizationDiv col-md-4 container\">\n    <span class=\"title\">Авторизация</span><br>\n    <input class=\"form-control\" [(ngModel)]=\"user.login\" type=\"text\" placeholder=\"Логин\"><br />\n    <input class=\"form-control\" [(ngModel)]=\"user.password\" type=\"password\"><br /><br />\n    <div class=\"button authorizationButton\" (click)=\"signIn()\">Войти</div><br>\n    <div class=\"forgotPassword\" (click)=\"forgotPassword()\">Забыл пароль</div><br><br>\n\n    <div class=\"button authorizationButton\" (click)=\"signUp()\">Зарегистрироваться</div><br>\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/chat-room/chat-room.component.html":
/*!*****************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/components/chat-room/chat-room.component.html ***!
  \*****************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"chatRoom\">\r\n  <div class=\"header\">\r\n    <span *ngFor=\"let userName of usersNames\">, {{ userName }}</span>\r\n  </div>\r\n  <div class=\"createMessage\">\r\n    <input class=\"inline form-control createText\" type=\"text\" [(ngModel)]=\"createText\">\r\n    <span class=\"button inline sendButton\" (click)=\"sendMessage()\">Отправить</span>\r\n  </div>\r\n  <div class=\"messages\">\r\n    <ng-container *ngFor=\"let message of messages\">\r\n      <div class=\"message acceptedMessage\">\r\n        <span class=\"senderName\">{{ message.sender.nickName }}: </span>\r\n        <span class=\"acceptText\">{{ message.text }}</span>\r\n      </div><br>\r\n    </ng-container>\r\n  </div>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/chat-rooms/chat-rooms.component.html":
/*!*******************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/components/chat-rooms/chat-rooms.component.html ***!
  \*******************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"chatRooms\">\r\n  <a routerLink=\"/chat-room/null\" class=\"chatRoom\">\r\n    <span class=\"chatRoomName\">CreatorName, Name, Name, Name, Name</span><br>\r\n    <span class=\"lastMessage\">LastMessageSender: LastMessageTeeeeeeeeeeeeeeeeeeeext</span>\r\n  </a>\r\n  <div *ngFor=\"let chatRoom of chatRooms\">\r\n    <a routerLink=\"/chat-room/{{chatRoom.id}}\" class=\"chatRoom\">\r\n      <span class=\"creatorName\">{{ chatRoom.creatorName }}</span>\r\n      <span *ngFor=\"let userName of chatRoom.userNames\">, {{ userName }}</span><br>\r\n      <span class=\"lastMessage\">{{ chatRoom.lastMessageSender }}: {{ chatRoom.lastMessageText }}</span>\r\n    </a>\r\n  </div>\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/post/post.component.html":
/*!*******************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/components/post/post.component.html ***!
  \*******************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"postDiv container\">\r\n  <a routerLink=\"/user-profile/{{sender.id}}\" class=\"postSender\"> sender.nickName </a>\r\n  <span class=\"form-control postText\">{{ post.text }}</span>\r\n  <div class=\"postMedia\">\r\n    <!-- <span>ЯбеспонятиякакздесьотобразитьмедиаАААААААА</span> -->\r\n  </div>\r\n</div>\r\n<div class=\"postComments\">\r\n  <!--КОООООМЕНТЫ ????-->\r\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/registration/registration.component.html":
/*!***********************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/components/registration/registration.component.html ***!
  \***********************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"registrationDiv col-md-4 container\">\n    <span class=\"title\">Регистрация</span><br>\n    <input class=\"form-control\" [(ngModel)]=\"user.login\" type=\"text\" placeholder=\"Логин\"><br />\n    <input class=\"form-control\" [(ngModel)]=\"user.password\" type=\"password\" placeholder=\"Пароль\"><br /><br />\n    <input class=\"form-control\" [(ngModel)]=\"user.email\" type=\"text\" placeholder=\"Почта\"><br />\n    <input class=\"form-control\" [(ngModel)]=\"user.nickName\" type=\"text\" placeholder=\"Ник\"><br />\n    <span>Пол</span>\n    <input class=\"form-control\" type=\"radio\" id=\"isMan1\" name=\"isMan\" value=\"Мужской\">\n    <input class=\"form-control\" type=\"radio\" id=\"isMan2\" name=\"isMan\" value=\"Женский\"><br />\n\n    <div class=\"button authorizationButton\" (click)=\"signUp()\">Зарегистрироваться</div><br>\n    <div class=\"button authorizationButton\" (click)=\"signIn ()\">Войти</div>\n</div>");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/user-profile-posts/user-profile-posts.component.html":
/*!***********************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/components/user-profile-posts/user-profile-posts.component.html ***!
  \***********************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"userPosts\">\r\n    <div  class=\"writePost container\"> <!--*ngIf=\"isMayEdit\"-->\r\n        <span class=\"writePostTitle\">Создайте свой новый пост здесь. </span>\r\n        <span class=\"errorMessage\" *ngIf=\"isError\">Похоже что вы сделали что-то не так =(</span><br>\r\n        <textarea class=\"form-control writePostText\" [(ngModel)]=\"post.text\" maxlength=\"3000\"></textarea>\r\n        <span class=\"addMediaButton button\">Добавить файл</span>\r\n        <span class=\"sendPostButton button\" (click)=\"createPost()\">Опубликовать</span>\r\n    </div>\r\n    <div class=\"userContact\"></div>\r\n    <div class=\"readPosts container\">\r\n        <div *ngFor=\"let post of posts\">\r\n            <app-post [post]=\"post\"></app-post>\r\n        </div>\r\n    </div>\r\n</div>");

/***/ }),

/***/ "./node_modules/tslib/tslib.es6.js":
/*!*****************************************!*\
  !*** ./node_modules/tslib/tslib.es6.js ***!
  \*****************************************/
/*! exports provided: __extends, __assign, __rest, __decorate, __param, __metadata, __awaiter, __generator, __exportStar, __values, __read, __spread, __spreadArrays, __await, __asyncGenerator, __asyncDelegator, __asyncValues, __makeTemplateObject, __importStar, __importDefault */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__extends", function() { return __extends; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__assign", function() { return __assign; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__rest", function() { return __rest; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__decorate", function() { return __decorate; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__param", function() { return __param; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__metadata", function() { return __metadata; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__awaiter", function() { return __awaiter; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__generator", function() { return __generator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__exportStar", function() { return __exportStar; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__values", function() { return __values; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__read", function() { return __read; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spread", function() { return __spread; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spreadArrays", function() { return __spreadArrays; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__await", function() { return __await; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncGenerator", function() { return __asyncGenerator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncDelegator", function() { return __asyncDelegator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncValues", function() { return __asyncValues; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__makeTemplateObject", function() { return __makeTemplateObject; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importStar", function() { return __importStar; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importDefault", function() { return __importDefault; });
/*! *****************************************************************************
Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the Apache License, Version 2.0 (the "License"); you may not use
this file except in compliance with the License. You may obtain a copy of the
License at http://www.apache.org/licenses/LICENSE-2.0

THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
MERCHANTABLITY OR NON-INFRINGEMENT.

See the Apache Version 2.0 License for specific language governing permissions
and limitations under the License.
***************************************************************************** */
/* global Reflect, Promise */

var extendStatics = function(d, b) {
    extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return extendStatics(d, b);
};

function __extends(d, b) {
    extendStatics(d, b);
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
}

var __assign = function() {
    __assign = Object.assign || function __assign(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p)) t[p] = s[p];
        }
        return t;
    }
    return __assign.apply(this, arguments);
}

function __rest(s, e) {
    var t = {};
    for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
        t[p] = s[p];
    if (s != null && typeof Object.getOwnPropertySymbols === "function")
        for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
            if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                t[p[i]] = s[p[i]];
        }
    return t;
}

function __decorate(decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
}

function __param(paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
}

function __metadata(metadataKey, metadataValue) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(metadataKey, metadataValue);
}

function __awaiter(thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
}

function __generator(thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
}

function __exportStar(m, exports) {
    for (var p in m) if (!exports.hasOwnProperty(p)) exports[p] = m[p];
}

function __values(o) {
    var m = typeof Symbol === "function" && o[Symbol.iterator], i = 0;
    if (m) return m.call(o);
    return {
        next: function () {
            if (o && i >= o.length) o = void 0;
            return { value: o && o[i++], done: !o };
        }
    };
}

function __read(o, n) {
    var m = typeof Symbol === "function" && o[Symbol.iterator];
    if (!m) return o;
    var i = m.call(o), r, ar = [], e;
    try {
        while ((n === void 0 || n-- > 0) && !(r = i.next()).done) ar.push(r.value);
    }
    catch (error) { e = { error: error }; }
    finally {
        try {
            if (r && !r.done && (m = i["return"])) m.call(i);
        }
        finally { if (e) throw e.error; }
    }
    return ar;
}

function __spread() {
    for (var ar = [], i = 0; i < arguments.length; i++)
        ar = ar.concat(__read(arguments[i]));
    return ar;
}

function __spreadArrays() {
    for (var s = 0, i = 0, il = arguments.length; i < il; i++) s += arguments[i].length;
    for (var r = Array(s), k = 0, i = 0; i < il; i++)
        for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
            r[k] = a[j];
    return r;
};

function __await(v) {
    return this instanceof __await ? (this.v = v, this) : new __await(v);
}

function __asyncGenerator(thisArg, _arguments, generator) {
    if (!Symbol.asyncIterator) throw new TypeError("Symbol.asyncIterator is not defined.");
    var g = generator.apply(thisArg, _arguments || []), i, q = [];
    return i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i;
    function verb(n) { if (g[n]) i[n] = function (v) { return new Promise(function (a, b) { q.push([n, v, a, b]) > 1 || resume(n, v); }); }; }
    function resume(n, v) { try { step(g[n](v)); } catch (e) { settle(q[0][3], e); } }
    function step(r) { r.value instanceof __await ? Promise.resolve(r.value.v).then(fulfill, reject) : settle(q[0][2], r); }
    function fulfill(value) { resume("next", value); }
    function reject(value) { resume("throw", value); }
    function settle(f, v) { if (f(v), q.shift(), q.length) resume(q[0][0], q[0][1]); }
}

function __asyncDelegator(o) {
    var i, p;
    return i = {}, verb("next"), verb("throw", function (e) { throw e; }), verb("return"), i[Symbol.iterator] = function () { return this; }, i;
    function verb(n, f) { i[n] = o[n] ? function (v) { return (p = !p) ? { value: __await(o[n](v)), done: n === "return" } : f ? f(v) : v; } : f; }
}

function __asyncValues(o) {
    if (!Symbol.asyncIterator) throw new TypeError("Symbol.asyncIterator is not defined.");
    var m = o[Symbol.asyncIterator], i;
    return m ? m.call(o) : (o = typeof __values === "function" ? __values(o) : o[Symbol.iterator](), i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i);
    function verb(n) { i[n] = o[n] && function (v) { return new Promise(function (resolve, reject) { v = o[n](v), settle(resolve, reject, v.done, v.value); }); }; }
    function settle(resolve, reject, d, v) { Promise.resolve(v).then(function(v) { resolve({ value: v, done: d }); }, reject); }
}

function __makeTemplateObject(cooked, raw) {
    if (Object.defineProperty) { Object.defineProperty(cooked, "raw", { value: raw }); } else { cooked.raw = raw; }
    return cooked;
};

function __importStar(mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
    result.default = mod;
    return result;
}

function __importDefault(mod) {
    return (mod && mod.__esModule) ? mod : { default: mod };
}


/***/ }),

/***/ "./src/app/Components/side-bar/side-bar.component.css":
/*!************************************************************!*\
  !*** ./src/app/Components/side-bar/side-bar.component.css ***!
  \************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".menu {\r\n    font-size: 22px;\r\n    padding: 0px;\r\n}\r\n\r\n.logoLi {\r\n    font-size: 30px;\r\n    text-align: center;\r\n    padding: 0px;\r\n    font-family: 'Permanent Marker', cursive;\r\n    color: var(--logo-font-color);\r\n    border-bottom: 1px solid var(--border-color);\r\n}\r\n\r\n.menuLi {\r\n    padding-left: 10px;\r\n    margin-top: 17px;\r\n    list-style-type: none;\r\n    cursor: pointer;\r\n    transition: 0.3s;\r\n}\r\n\r\n.menuLi:hover {\r\n        background-color: var(--second-background-color);\r\n        border-radius: 15px;\r\n        color: var(--second-font-color);\r\n        transition: 0.3s;\r\n    }\r\n\r\n.sideBarIcon {\r\n    width: 30px;\r\n    height: 30px;\r\n    margin-right: 6px;\r\n}\r\n\r\na {\r\n    color: var(--font-color);\r\n    text-decoration: none\r\n  }\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvQ29tcG9uZW50cy9zaWRlLWJhci9zaWRlLWJhci5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0lBQ0ksZUFBZTtJQUNmLFlBQVk7QUFDaEI7O0FBRUE7SUFDSSxlQUFlO0lBQ2Ysa0JBQWtCO0lBQ2xCLFlBQVk7SUFDWix3Q0FBd0M7SUFDeEMsNkJBQTZCO0lBQzdCLDRDQUE0QztBQUNoRDs7QUFFQTtJQUNJLGtCQUFrQjtJQUNsQixnQkFBZ0I7SUFDaEIscUJBQXFCO0lBQ3JCLGVBQWU7SUFDZixnQkFBZ0I7QUFDcEI7O0FBRUk7UUFDSSxnREFBZ0Q7UUFDaEQsbUJBQW1CO1FBQ25CLCtCQUErQjtRQUMvQixnQkFBZ0I7SUFDcEI7O0FBRUo7SUFDSSxXQUFXO0lBQ1gsWUFBWTtJQUNaLGlCQUFpQjtBQUNyQjs7QUFDQTtJQUNJLHdCQUF3QjtJQUN4QjtFQUNGIiwiZmlsZSI6InNyYy9hcHAvQ29tcG9uZW50cy9zaWRlLWJhci9zaWRlLWJhci5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLm1lbnUge1xyXG4gICAgZm9udC1zaXplOiAyMnB4O1xyXG4gICAgcGFkZGluZzogMHB4O1xyXG59XHJcblxyXG4ubG9nb0xpIHtcclxuICAgIGZvbnQtc2l6ZTogMzBweDtcclxuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICAgIHBhZGRpbmc6IDBweDtcclxuICAgIGZvbnQtZmFtaWx5OiAnUGVybWFuZW50IE1hcmtlcicsIGN1cnNpdmU7XHJcbiAgICBjb2xvcjogdmFyKC0tbG9nby1mb250LWNvbG9yKTtcclxuICAgIGJvcmRlci1ib3R0b206IDFweCBzb2xpZCB2YXIoLS1ib3JkZXItY29sb3IpO1xyXG59XHJcblxyXG4ubWVudUxpIHtcclxuICAgIHBhZGRpbmctbGVmdDogMTBweDtcclxuICAgIG1hcmdpbi10b3A6IDE3cHg7XHJcbiAgICBsaXN0LXN0eWxlLXR5cGU6IG5vbmU7XHJcbiAgICBjdXJzb3I6IHBvaW50ZXI7XHJcbiAgICB0cmFuc2l0aW9uOiAwLjNzO1xyXG59XHJcblxyXG4gICAgLm1lbnVMaTpob3ZlciB7XHJcbiAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogdmFyKC0tc2Vjb25kLWJhY2tncm91bmQtY29sb3IpO1xyXG4gICAgICAgIGJvcmRlci1yYWRpdXM6IDE1cHg7XHJcbiAgICAgICAgY29sb3I6IHZhcigtLXNlY29uZC1mb250LWNvbG9yKTtcclxuICAgICAgICB0cmFuc2l0aW9uOiAwLjNzO1xyXG4gICAgfVxyXG5cclxuLnNpZGVCYXJJY29uIHtcclxuICAgIHdpZHRoOiAzMHB4O1xyXG4gICAgaGVpZ2h0OiAzMHB4O1xyXG4gICAgbWFyZ2luLXJpZ2h0OiA2cHg7XHJcbn1cclxuYSB7XHJcbiAgICBjb2xvcjogdmFyKC0tZm9udC1jb2xvcik7XHJcbiAgICB0ZXh0LWRlY29yYXRpb246IG5vbmVcclxuICB9Il19 */");

/***/ }),

/***/ "./src/app/Components/side-bar/side-bar.component.ts":
/*!***********************************************************!*\
  !*** ./src/app/Components/side-bar/side-bar.component.ts ***!
  \***********************************************************/
/*! exports provided: SideBarComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SideBarComponent", function() { return SideBarComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");



let SideBarComponent = class SideBarComponent {
    constructor(router) {
        this.router = router;
    }
    get userId() {
        let answer = localStorage.getItem("userId");
        if (answer) {
            return answer;
        }
        else {
            return "null";
        }
    }
    ngOnInit() {
    }
};
SideBarComponent.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
SideBarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-side-bar',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./side-bar.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/Components/side-bar/side-bar.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./side-bar.component.css */ "./src/app/Components/side-bar/side-bar.component.css")).default]
    })
], SideBarComponent);



/***/ }),

/***/ "./src/app/Components/user-profile/user-profile.component.css":
/*!********************************************************************!*\
  !*** ./src/app/Components/user-profile/user-profile.component.css ***!
  \********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".userProfileMainDiv {\r\n    height: 400px;\r\n    border-bottom: 3px solid var(--second-background-color);\r\n}\r\n.inl{\r\n    display: inline-block;\r\n}\r\n.userAvatar {\r\n    height: 400px;\r\n    width: 300px;\r\n    padding: unset;\r\n    float: left;\r\n    border-right: 1px solid var(--second-background-color);\r\n}\r\n.userAvatarImg {\r\n    height: 400px;\r\n    width: 300px;\r\n}\r\n.userMainInfo {\r\n    position: relative;\r\n    /* margin-left: 10px; */\r\n    height: 100%;\r\n    /* width: 100%; */\r\n    float: left;\r\n    padding: 5px;\r\n}\r\n.userNickName{\r\n    font-size: 26px;\r\n    border-bottom: 1px solid var(--border-color);\r\n}\r\n.mediaButtons{\r\n    position: absolute;\r\n    text-align: center;\r\n    width: 100%;\r\n    border-top: 1px solid var(--second-background-color);\r\n    bottom: 0;\r\n}\r\n.mediaButton{\r\n    display: inline-block;\r\n    margin-bottom: 10px;\r\n    margin-top: 5px;\r\n    cursor: pointer;\r\n    transition: 0.5s;\r\n    margin-right: 12px;\r\n    width: 150px;\r\n}\r\n.mediaButton:hover{\r\n    background: var(--second-background-color);\r\n    border-radius: 5px;\r\n    transition: 0.3s;\r\n}\r\n.mediaCount{\r\n    font-size: 30px;\r\n    color: var(--second-font-color);\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvQ29tcG9uZW50cy91c2VyLXByb2ZpbGUvdXNlci1wcm9maWxlLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7SUFDSSxhQUFhO0lBQ2IsdURBQXVEO0FBQzNEO0FBQ0E7SUFDSSxxQkFBcUI7QUFDekI7QUFDQTtJQUNJLGFBQWE7SUFDYixZQUFZO0lBQ1osY0FBYztJQUNkLFdBQVc7SUFDWCxzREFBc0Q7QUFDMUQ7QUFDQTtJQUNJLGFBQWE7SUFDYixZQUFZO0FBQ2hCO0FBQ0E7SUFDSSxrQkFBa0I7SUFDbEIsdUJBQXVCO0lBQ3ZCLFlBQVk7SUFDWixpQkFBaUI7SUFDakIsV0FBVztJQUNYLFlBQVk7QUFDaEI7QUFDQTtJQUNJLGVBQWU7SUFDZiw0Q0FBNEM7QUFDaEQ7QUFDQTtJQUNJLGtCQUFrQjtJQUNsQixrQkFBa0I7SUFDbEIsV0FBVztJQUNYLG9EQUFvRDtJQUNwRCxTQUFTO0FBQ2I7QUFDQTtJQUNJLHFCQUFxQjtJQUNyQixtQkFBbUI7SUFDbkIsZUFBZTtJQUNmLGVBQWU7SUFDZixnQkFBZ0I7SUFDaEIsa0JBQWtCO0lBQ2xCLFlBQVk7QUFDaEI7QUFDQTtJQUNJLDBDQUEwQztJQUMxQyxrQkFBa0I7SUFDbEIsZ0JBQWdCO0FBQ3BCO0FBQ0E7SUFDSSxlQUFlO0lBQ2YsK0JBQStCO0FBQ25DIiwiZmlsZSI6InNyYy9hcHAvQ29tcG9uZW50cy91c2VyLXByb2ZpbGUvdXNlci1wcm9maWxlLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIudXNlclByb2ZpbGVNYWluRGl2IHtcclxuICAgIGhlaWdodDogNDAwcHg7XHJcbiAgICBib3JkZXItYm90dG9tOiAzcHggc29saWQgdmFyKC0tc2Vjb25kLWJhY2tncm91bmQtY29sb3IpO1xyXG59XHJcbi5pbmx7XHJcbiAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XHJcbn1cclxuLnVzZXJBdmF0YXIge1xyXG4gICAgaGVpZ2h0OiA0MDBweDtcclxuICAgIHdpZHRoOiAzMDBweDtcclxuICAgIHBhZGRpbmc6IHVuc2V0O1xyXG4gICAgZmxvYXQ6IGxlZnQ7XHJcbiAgICBib3JkZXItcmlnaHQ6IDFweCBzb2xpZCB2YXIoLS1zZWNvbmQtYmFja2dyb3VuZC1jb2xvcik7XHJcbn1cclxuLnVzZXJBdmF0YXJJbWcge1xyXG4gICAgaGVpZ2h0OiA0MDBweDtcclxuICAgIHdpZHRoOiAzMDBweDtcclxufVxyXG4udXNlck1haW5JbmZvIHtcclxuICAgIHBvc2l0aW9uOiByZWxhdGl2ZTtcclxuICAgIC8qIG1hcmdpbi1sZWZ0OiAxMHB4OyAqL1xyXG4gICAgaGVpZ2h0OiAxMDAlO1xyXG4gICAgLyogd2lkdGg6IDEwMCU7ICovXHJcbiAgICBmbG9hdDogbGVmdDtcclxuICAgIHBhZGRpbmc6IDVweDtcclxufVxyXG4udXNlck5pY2tOYW1le1xyXG4gICAgZm9udC1zaXplOiAyNnB4O1xyXG4gICAgYm9yZGVyLWJvdHRvbTogMXB4IHNvbGlkIHZhcigtLWJvcmRlci1jb2xvcik7XHJcbn1cclxuLm1lZGlhQnV0dG9uc3tcclxuICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcclxuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICAgIHdpZHRoOiAxMDAlO1xyXG4gICAgYm9yZGVyLXRvcDogMXB4IHNvbGlkIHZhcigtLXNlY29uZC1iYWNrZ3JvdW5kLWNvbG9yKTtcclxuICAgIGJvdHRvbTogMDtcclxufVxyXG4ubWVkaWFCdXR0b257XHJcbiAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XHJcbiAgICBtYXJnaW4tYm90dG9tOiAxMHB4O1xyXG4gICAgbWFyZ2luLXRvcDogNXB4O1xyXG4gICAgY3Vyc29yOiBwb2ludGVyO1xyXG4gICAgdHJhbnNpdGlvbjogMC41cztcclxuICAgIG1hcmdpbi1yaWdodDogMTJweDtcclxuICAgIHdpZHRoOiAxNTBweDtcclxufVxyXG4ubWVkaWFCdXR0b246aG92ZXJ7XHJcbiAgICBiYWNrZ3JvdW5kOiB2YXIoLS1zZWNvbmQtYmFja2dyb3VuZC1jb2xvcik7XHJcbiAgICBib3JkZXItcmFkaXVzOiA1cHg7XHJcbiAgICB0cmFuc2l0aW9uOiAwLjNzO1xyXG59XHJcbi5tZWRpYUNvdW50e1xyXG4gICAgZm9udC1zaXplOiAzMHB4O1xyXG4gICAgY29sb3I6IHZhcigtLXNlY29uZC1mb250LWNvbG9yKTtcclxufSJdfQ== */");

/***/ }),

/***/ "./src/app/Components/user-profile/user-profile.component.ts":
/*!*******************************************************************!*\
  !*** ./src/app/Components/user-profile/user-profile.component.ts ***!
  \*******************************************************************/
/*! exports provided: UserProfileComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserProfileComponent", function() { return UserProfileComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/Services/users.service */ "./src/app/Services/users.service.ts");




let UserProfileComponent = class UserProfileComponent {
    constructor(userService, route) {
        this.userService = userService;
        this.route = route;
    }
    get userId() {
        let answer = localStorage.getItem("userId");
        if (answer) {
            return answer;
        }
        else {
            return "null";
        }
    }
    ngOnInit() {
        this.route.params.subscribe(params => {
            const id = params['id'];
            if (id) {
                this.userService.getUser(id)
                    .subscribe(result => this.userAccept(result));
            }
        });
    }
    userAccept(result) {
        this.selectedUser = result;
        if (this.selectedUser.id == localStorage.getItem("userId"))
            this.isMayEdit = true;
    }
};
UserProfileComponent.ctorParameters = () => [
    { type: src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_3__["UsersService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"] }
];
UserProfileComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-user-profile',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./user-profile.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/Components/user-profile/user-profile.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./user-profile.component.css */ "./src/app/Components/user-profile/user-profile.component.css")).default]
    })
], UserProfileComponent);



/***/ }),

/***/ "./src/app/Services/users.service.ts":
/*!*******************************************!*\
  !*** ./src/app/Services/users.service.ts ***!
  \*******************************************/
/*! exports provided: UsersService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UsersService", function() { return UsersService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let UsersService = class UsersService {
    constructor(http) {
        this.http = http;
    }
    initializeUser() {
        return { id: null, login: null, password: null, nickName: null, isMan: true, email: null, contentId: null, wallId: null, medias: null, photoCount: null, friendsCount: null };
    }
    getUser(id) {
        return this.http.get('/api/user/' + id);
    }
    signIn(user) {
        debugger;
        return this.http.post('http://localhost:44368/api/user/login', user);
    }
    signUp(user) {
        this.http.post('/api/user/signUp', user);
    }
};
UsersService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
UsersService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], UsersService);



/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm2015/common.js");
/* harmony import */ var _Components_user_profile_user_profile_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./Components/user-profile/user-profile.component */ "./src/app/Components/user-profile/user-profile.component.ts");
/* harmony import */ var _components_authorization_authorization_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./components/authorization/authorization.component */ "./src/app/components/authorization/authorization.component.ts");
/* harmony import */ var _components_registration_registration_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./components/registration/registration.component */ "./src/app/components/registration/registration.component.ts");
/* harmony import */ var _components_chat_rooms_chat_rooms_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./components/chat-rooms/chat-rooms.component */ "./src/app/components/chat-rooms/chat-rooms.component.ts");
/* harmony import */ var _components_chat_room_chat_room_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./components/chat-room/chat-room.component */ "./src/app/components/chat-room/chat-room.component.ts");









const routes = [
    { path: 'authorization', component: _components_authorization_authorization_component__WEBPACK_IMPORTED_MODULE_5__["AuthorizationComponent"] },
    { path: 'registration', component: _components_registration_registration_component__WEBPACK_IMPORTED_MODULE_6__["RegistrationComponent"] },
    { path: 'user-profile/:id', component: _Components_user_profile_user_profile_component__WEBPACK_IMPORTED_MODULE_4__["UserProfileComponent"] },
    { path: 'chat-rooms/:id', component: _components_chat_rooms_chat_rooms_component__WEBPACK_IMPORTED_MODULE_7__["ChatRoomsComponent"] },
    { path: 'chat-room/:id', component: _components_chat_room_chat_room_component__WEBPACK_IMPORTED_MODULE_8__["ChatRoomComponent"] }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        declarations: [],
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
            _angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes)
        ],
        exports: [
            _angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]
        ]
    })
], AppRoutingModule);



/***/ }),

/***/ "./src/app/app.component.css":
/*!***********************************!*\
  !*** ./src/app/app.component.css ***!
  \***********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".rightSideBar{\r\n  float: left;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvYXBwLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxXQUFXO0FBQ2IiLCJmaWxlIjoic3JjL2FwcC9hcHAuY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5yaWdodFNpZGVCYXJ7XHJcbiAgZmxvYXQ6IGxlZnQ7XHJcbn0iXX0= */");

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AppComponent = class AppComponent {
    constructor() {
        this.title = 'Stillborn';
    }
};
AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-root',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")).default]
    })
], AppComponent);



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _Components_user_profile_user_profile_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./Components/user-profile/user-profile.component */ "./src/app/Components/user-profile/user-profile.component.ts");
/* harmony import */ var _Components_side_bar_side_bar_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./Components/side-bar/side-bar.component */ "./src/app/Components/side-bar/side-bar.component.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _components_authorization_authorization_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./components/authorization/authorization.component */ "./src/app/components/authorization/authorization.component.ts");
/* harmony import */ var _Services_users_service__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./Services/users.service */ "./src/app/Services/users.service.ts");
/* harmony import */ var _components_registration_registration_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./components/registration/registration.component */ "./src/app/components/registration/registration.component.ts");
/* harmony import */ var _components_user_profile_posts_user_profile_posts_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./components/user-profile-posts/user-profile-posts.component */ "./src/app/components/user-profile-posts/user-profile-posts.component.ts");
/* harmony import */ var _components_post_post_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./components/post/post.component */ "./src/app/components/post/post.component.ts");
/* harmony import */ var _services_posts_service__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./services/posts.service */ "./src/app/services/posts.service.ts");
/* harmony import */ var _components_chat_rooms_chat_rooms_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./components/chat-rooms/chat-rooms.component */ "./src/app/components/chat-rooms/chat-rooms.component.ts");
/* harmony import */ var _components_chat_room_chat_room_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./components/chat-room/chat-room.component */ "./src/app/components/chat-room/chat-room.component.ts");

















let AppModule = class AppModule {
};
AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
        declarations: [
            _app_component__WEBPACK_IMPORTED_MODULE_5__["AppComponent"],
            _Components_user_profile_user_profile_component__WEBPACK_IMPORTED_MODULE_6__["UserProfileComponent"],
            _Components_side_bar_side_bar_component__WEBPACK_IMPORTED_MODULE_7__["SideBarComponent"],
            _components_authorization_authorization_component__WEBPACK_IMPORTED_MODULE_9__["AuthorizationComponent"],
            _components_registration_registration_component__WEBPACK_IMPORTED_MODULE_11__["RegistrationComponent"],
            _components_user_profile_posts_user_profile_posts_component__WEBPACK_IMPORTED_MODULE_12__["UserProfilePostsComponent"],
            _components_post_post_component__WEBPACK_IMPORTED_MODULE_13__["PostComponent"],
            _components_chat_rooms_chat_rooms_component__WEBPACK_IMPORTED_MODULE_15__["ChatRoomsComponent"],
            _components_chat_room_chat_room_component__WEBPACK_IMPORTED_MODULE_16__["ChatRoomComponent"]
        ],
        imports: [
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_4__["AppRoutingModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_8__["HttpClientModule"]
        ],
        providers: [
            _Services_users_service__WEBPACK_IMPORTED_MODULE_10__["UsersService"],
            _services_posts_service__WEBPACK_IMPORTED_MODULE_14__["PostsService"]
        ],
        bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_5__["AppComponent"]]
    })
], AppModule);



/***/ }),

/***/ "./src/app/components/authorization/authorization.component.css":
/*!**********************************************************************!*\
  !*** ./src/app/components/authorization/authorization.component.css ***!
  \**********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".authorizationDiv{\r\n    text-align: center;\r\n    margin-top: 50px;\r\n    align-items: center;\r\n    top: 50%;\r\n}\r\n.title{\r\n    font-size: 32px;\r\n    margin-bottom: 100px;\r\n}\r\ninput{\r\n    display: unset;\r\n    text-align: center;\r\n    width: 300px;\r\n    margin-top: 10px;\r\n}\r\n.authorizationButton{\r\n    display: inline-block;\r\n    margin-top: 10px;\r\n    width: 300px;\r\n}\r\n.forgotPassword{\r\n    cursor: pointer;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29tcG9uZW50cy9hdXRob3JpemF0aW9uL2F1dGhvcml6YXRpb24uY29tcG9uZW50LmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtJQUNJLGtCQUFrQjtJQUNsQixnQkFBZ0I7SUFDaEIsbUJBQW1CO0lBQ25CLFFBQVE7QUFDWjtBQUNBO0lBQ0ksZUFBZTtJQUNmLG9CQUFvQjtBQUN4QjtBQUNBO0lBQ0ksY0FBYztJQUNkLGtCQUFrQjtJQUNsQixZQUFZO0lBQ1osZ0JBQWdCO0FBQ3BCO0FBRUE7SUFDSSxxQkFBcUI7SUFDckIsZ0JBQWdCO0lBQ2hCLFlBQVk7QUFDaEI7QUFFQTtJQUNJLGVBQWU7QUFDbkIiLCJmaWxlIjoic3JjL2FwcC9jb21wb25lbnRzL2F1dGhvcml6YXRpb24vYXV0aG9yaXphdGlvbi5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmF1dGhvcml6YXRpb25EaXZ7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICBtYXJnaW4tdG9wOiA1MHB4O1xyXG4gICAgYWxpZ24taXRlbXM6IGNlbnRlcjtcclxuICAgIHRvcDogNTAlO1xyXG59XHJcbi50aXRsZXtcclxuICAgIGZvbnQtc2l6ZTogMzJweDtcclxuICAgIG1hcmdpbi1ib3R0b206IDEwMHB4O1xyXG59XHJcbmlucHV0e1xyXG4gICAgZGlzcGxheTogdW5zZXQ7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICB3aWR0aDogMzAwcHg7XHJcbiAgICBtYXJnaW4tdG9wOiAxMHB4O1xyXG59XHJcblxyXG4uYXV0aG9yaXphdGlvbkJ1dHRvbntcclxuICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcclxuICAgIG1hcmdpbi10b3A6IDEwcHg7XHJcbiAgICB3aWR0aDogMzAwcHg7XHJcbn1cclxuXHJcbi5mb3Jnb3RQYXNzd29yZHtcclxuICAgIGN1cnNvcjogcG9pbnRlcjtcclxufSJdfQ== */");

/***/ }),

/***/ "./src/app/components/authorization/authorization.component.ts":
/*!*********************************************************************!*\
  !*** ./src/app/components/authorization/authorization.component.ts ***!
  \*********************************************************************/
/*! exports provided: AuthorizationComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthorizationComponent", function() { return AuthorizationComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/Services/users.service */ "./src/app/Services/users.service.ts");




let AuthorizationComponent = class AuthorizationComponent {
    constructor(router, usersService) {
        this.router = router;
        this.usersService = usersService;
        this.user = { login: null, password: null };
    }
    ngOnInit() {
    }
    signIn() {
        debugger;
        this.usersService.signIn(this.user).subscribe(result => this.goToProfile(result));
    }
    goToProfile(result) {
        if (result) {
            localStorage.setItem("userId", "result");
            this.router.navigate(['/user-profile/' + result]);
        }
        else {
            //ToDo если юзер не вошел
        }
    }
    forgotPassword() {
        this.router.navigate(['/forgot-password']);
    }
    signUp() {
        this.router.navigate(['/registration']);
    }
};
AuthorizationComponent.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] },
    { type: src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_3__["UsersService"] }
];
AuthorizationComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-authorization',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./authorization.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/authorization/authorization.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./authorization.component.css */ "./src/app/components/authorization/authorization.component.css")).default]
    })
], AuthorizationComponent);



/***/ }),

/***/ "./src/app/components/chat-room/chat-room.component.css":
/*!**************************************************************!*\
  !*** ./src/app/components/chat-room/chat-room.component.css ***!
  \**************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".chatRoom{\r\n  min-height: 100%;\r\n   height: 100%;\r\n}\r\n.header{\r\n  border-bottom: 1px solid var(--border-color);\r\n}\r\n.inline{\r\n  display: inline-block;\r\n}\r\n.createText{\r\n  width: 80%;\r\n}\r\n.sendButton{\r\n  width: 17%;\r\n  text-align: center;\r\n}\r\n.message{\r\n  padding: 5px;\r\n  background: black;\r\n  border-radius: 10px;\r\n}\r\n.acceptedMessage{\r\n  background: var(--second-background-color);\r\n}\r\n.sendedMessage{\r\n  background: var(--purple);\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29tcG9uZW50cy9jaGF0LXJvb20vY2hhdC1yb29tLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxnQkFBZ0I7R0FDZixZQUFZO0FBQ2Y7QUFDQTtFQUNFLDRDQUE0QztBQUM5QztBQUNBO0VBQ0UscUJBQXFCO0FBQ3ZCO0FBQ0E7RUFDRSxVQUFVO0FBQ1o7QUFDQTtFQUNFLFVBQVU7RUFDVixrQkFBa0I7QUFDcEI7QUFDQTtFQUNFLFlBQVk7RUFDWixpQkFBaUI7RUFDakIsbUJBQW1CO0FBQ3JCO0FBQ0E7RUFDRSwwQ0FBMEM7QUFDNUM7QUFDQTtFQUNFLHlCQUF5QjtBQUMzQiIsImZpbGUiOiJzcmMvYXBwL2NvbXBvbmVudHMvY2hhdC1yb29tL2NoYXQtcm9vbS5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmNoYXRSb29te1xyXG4gIG1pbi1oZWlnaHQ6IDEwMCU7XHJcbiAgIGhlaWdodDogMTAwJTtcclxufVxyXG4uaGVhZGVye1xyXG4gIGJvcmRlci1ib3R0b206IDFweCBzb2xpZCB2YXIoLS1ib3JkZXItY29sb3IpO1xyXG59XHJcbi5pbmxpbmV7XHJcbiAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xyXG59XHJcbi5jcmVhdGVUZXh0e1xyXG4gIHdpZHRoOiA4MCU7XHJcbn1cclxuLnNlbmRCdXR0b257XHJcbiAgd2lkdGg6IDE3JTtcclxuICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbn1cclxuLm1lc3NhZ2V7XHJcbiAgcGFkZGluZzogNXB4O1xyXG4gIGJhY2tncm91bmQ6IGJsYWNrO1xyXG4gIGJvcmRlci1yYWRpdXM6IDEwcHg7XHJcbn1cclxuLmFjY2VwdGVkTWVzc2FnZXtcclxuICBiYWNrZ3JvdW5kOiB2YXIoLS1zZWNvbmQtYmFja2dyb3VuZC1jb2xvcik7XHJcbn1cclxuLnNlbmRlZE1lc3NhZ2V7XHJcbiAgYmFja2dyb3VuZDogdmFyKC0tcHVycGxlKTtcclxufSJdfQ== */");

/***/ }),

/***/ "./src/app/components/chat-room/chat-room.component.ts":
/*!*************************************************************!*\
  !*** ./src/app/components/chat-room/chat-room.component.ts ***!
  \*************************************************************/
/*! exports provided: ChatRoomComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ChatRoomComponent", function() { return ChatRoomComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var src_app_services_chat_rooms_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/services/chat-rooms.service */ "./src/app/services/chat-rooms.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_services_message_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/services/message.service */ "./src/app/services/message.service.ts");
/* harmony import */ var _aspnet_signalr__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @aspnet/signalr */ "./node_modules/@aspnet/signalr/dist/esm/index.js");
/* harmony import */ var src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! src/app/Services/users.service */ "./src/app/Services/users.service.ts");







let ChatRoomComponent = class ChatRoomComponent {
    constructor(chatRoomsService, messageService, usersService, route) {
        this.chatRoomsService = chatRoomsService;
        this.messageService = messageService;
        this.usersService = usersService;
        this.route = route;
    }
    ngOnInit() {
        this.route.params.subscribe(params => {
            const id = params['id'];
            if (id) {
                this.chatRoomsService.getChatRoom(id).subscribe(result => this.chatRoom = result);
            }
        });
        this.chatRoomsService.getUsersNames(this.chatRoom.id).subscribe(result => this.usersNames = result);
        this._hubConnection = new _aspnet_signalr__WEBPACK_IMPORTED_MODULE_5__["HubConnectionBuilder"]()
            .withUrl('/hubs/chat', {
            accessTokenFactory: () => localStorage.getItem('token')
        }).build();
        this._hubConnection
            .start()
            .then(() => console.log('Connection started'))
            .catch(err => console.log('Error while starting connection: ' + err));
        this._hubConnection.on("Receive", (message) => {
            this.messages.push(this.messageService.getMessageViewModel(message));
        });
    }
    sendMessage() {
        debugger;
        let message;
        message.id = 1;
        message.chatRoomId = this.chatRoom.id;
        message.senderId = localStorage.getItem("userId");
        message.text = this.createText;
        message.contentId = null;
        this.messages.push(this.messageService.getMessageViewModel(message));
        this.messageService.sendMessage(message, this.chatRoom.id);
    }
};
ChatRoomComponent.ctorParameters = () => [
    { type: src_app_services_chat_rooms_service__WEBPACK_IMPORTED_MODULE_2__["ChatRoomsService"] },
    { type: src_app_services_message_service__WEBPACK_IMPORTED_MODULE_4__["MessageService"] },
    { type: src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_6__["UsersService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], ChatRoomComponent.prototype, "usersNames", void 0);
ChatRoomComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-chat-room',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./chat-room.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/chat-room/chat-room.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./chat-room.component.css */ "./src/app/components/chat-room/chat-room.component.css")).default]
    })
], ChatRoomComponent);



/***/ }),

/***/ "./src/app/components/chat-rooms/chat-rooms.component.css":
/*!****************************************************************!*\
  !*** ./src/app/components/chat-rooms/chat-rooms.component.css ***!
  \****************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".chatRoom{\r\n  border: 1px solid white;\r\n  padding: 10px;\r\n  border-radius: 10px;\r\n  margin-top: 10px;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29tcG9uZW50cy9jaGF0LXJvb21zL2NoYXQtcm9vbXMuY29tcG9uZW50LmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLHVCQUF1QjtFQUN2QixhQUFhO0VBQ2IsbUJBQW1CO0VBQ25CLGdCQUFnQjtBQUNsQiIsImZpbGUiOiJzcmMvYXBwL2NvbXBvbmVudHMvY2hhdC1yb29tcy9jaGF0LXJvb21zLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuY2hhdFJvb217XHJcbiAgYm9yZGVyOiAxcHggc29saWQgd2hpdGU7XHJcbiAgcGFkZGluZzogMTBweDtcclxuICBib3JkZXItcmFkaXVzOiAxMHB4O1xyXG4gIG1hcmdpbi10b3A6IDEwcHg7XHJcbn0iXX0= */");

/***/ }),

/***/ "./src/app/components/chat-rooms/chat-rooms.component.ts":
/*!***************************************************************!*\
  !*** ./src/app/components/chat-rooms/chat-rooms.component.ts ***!
  \***************************************************************/
/*! exports provided: ChatRoomsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ChatRoomsComponent", function() { return ChatRoomsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var src_app_services_chat_rooms_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/services/chat-rooms.service */ "./src/app/services/chat-rooms.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/Services/users.service */ "./src/app/Services/users.service.ts");





let ChatRoomsComponent = class ChatRoomsComponent {
    constructor(chatRoomsService, usersService, route) {
        this.chatRoomsService = chatRoomsService;
        this.usersService = usersService;
        this.route = route;
    }
    ngOnInit() {
        this.route.params.subscribe(params => {
            const id = params['id'];
            if (id) {
                this.chatRoomsService.getChatRooms(id)
                    .subscribe(result => this.acceptChatRooms(result));
            }
        });
    }
    acceptChatRooms(chatRooms) {
        chatRooms.forEach(r => {
            let chatRoom;
            chatRoom.id = r.id;
            chatRoom.creatorId = r.creatorId;
            this.usersService.getUser(chatRoom.creatorId).subscribe(result => chatRoom.creatorName = result.nickName);
            this.chatRoomsService.getLastMessage(chatRoom.id).subscribe(result => {
                this.usersService.getUser(result.senderId).subscribe(secondResult => chatRoom.lastMessageSender = secondResult.nickName);
                chatRoom.lastMessageText = result.text;
            });
            this.chatRoomsService.getUsersNames(chatRoom.id).subscribe(result => chatRoom.userNames = result);
            this.chatRooms.push(chatRoom);
        });
    }
};
ChatRoomsComponent.ctorParameters = () => [
    { type: src_app_services_chat_rooms_service__WEBPACK_IMPORTED_MODULE_2__["ChatRoomsService"] },
    { type: src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_4__["UsersService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"] }
];
ChatRoomsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-chat-rooms',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./chat-rooms.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/chat-rooms/chat-rooms.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./chat-rooms.component.css */ "./src/app/components/chat-rooms/chat-rooms.component.css")).default]
    })
], ChatRoomsComponent);



/***/ }),

/***/ "./src/app/components/post/post.component.css":
/*!****************************************************!*\
  !*** ./src/app/components/post/post.component.css ***!
  \****************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".postDiv{\r\n  border: 1px solid var(--second-background-color);\r\n  border-radius: 10px;\r\n  width: 600px;\r\n  height: auto;\r\n  margin-top: 20px;\r\n}\r\n.postText{\r\n  margin-top: 10px;\r\n  margin-bottom: 10px;\r\n  background: var(--second-background-color);\r\n  border: none;\r\n  color: var(--font-color);\r\n  height: auto;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29tcG9uZW50cy9wb3N0L3Bvc3QuY29tcG9uZW50LmNzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLGdEQUFnRDtFQUNoRCxtQkFBbUI7RUFDbkIsWUFBWTtFQUNaLFlBQVk7RUFDWixnQkFBZ0I7QUFDbEI7QUFDQTtFQUNFLGdCQUFnQjtFQUNoQixtQkFBbUI7RUFDbkIsMENBQTBDO0VBQzFDLFlBQVk7RUFDWix3QkFBd0I7RUFDeEIsWUFBWTtBQUNkIiwiZmlsZSI6InNyYy9hcHAvY29tcG9uZW50cy9wb3N0L3Bvc3QuY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5wb3N0RGl2e1xyXG4gIGJvcmRlcjogMXB4IHNvbGlkIHZhcigtLXNlY29uZC1iYWNrZ3JvdW5kLWNvbG9yKTtcclxuICBib3JkZXItcmFkaXVzOiAxMHB4O1xyXG4gIHdpZHRoOiA2MDBweDtcclxuICBoZWlnaHQ6IGF1dG87XHJcbiAgbWFyZ2luLXRvcDogMjBweDtcclxufVxyXG4ucG9zdFRleHR7XHJcbiAgbWFyZ2luLXRvcDogMTBweDtcclxuICBtYXJnaW4tYm90dG9tOiAxMHB4O1xyXG4gIGJhY2tncm91bmQ6IHZhcigtLXNlY29uZC1iYWNrZ3JvdW5kLWNvbG9yKTtcclxuICBib3JkZXI6IG5vbmU7XHJcbiAgY29sb3I6IHZhcigtLWZvbnQtY29sb3IpO1xyXG4gIGhlaWdodDogYXV0bztcclxufSJdfQ== */");

/***/ }),

/***/ "./src/app/components/post/post.component.ts":
/*!***************************************************!*\
  !*** ./src/app/components/post/post.component.ts ***!
  \***************************************************/
/*! exports provided: PostComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PostComponent", function() { return PostComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/Services/users.service */ "./src/app/Services/users.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");




let PostComponent = class PostComponent {
    constructor(userService, route) {
        this.userService = userService;
        this.route = route;
    }
    ngOnInit() {
        if (this.post.senderId) {
            this.userService.getUser(this.post.senderId)
                .subscribe(result => this.sender = result);
        }
    }
};
PostComponent.ctorParameters = () => [
    { type: src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_2__["UsersService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], PostComponent.prototype, "post", void 0);
PostComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-post',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./post.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/post/post.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./post.component.css */ "./src/app/components/post/post.component.css")).default]
    })
], PostComponent);



/***/ }),

/***/ "./src/app/components/registration/registration.component.css":
/*!********************************************************************!*\
  !*** ./src/app/components/registration/registration.component.css ***!
  \********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".registrationDiv{\r\n    text-align: center;\r\n}\r\n.title{\r\n    font-size: 32px;\r\n    margin-bottom: 100px;\r\n}\r\ninput{\r\n    display: unset;\r\n    text-align: center;\r\n    width: 300px;\r\n    margin-top: 10px;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29tcG9uZW50cy9yZWdpc3RyYXRpb24vcmVnaXN0cmF0aW9uLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7SUFDSSxrQkFBa0I7QUFDdEI7QUFDQTtJQUNJLGVBQWU7SUFDZixvQkFBb0I7QUFDeEI7QUFDQTtJQUNJLGNBQWM7SUFDZCxrQkFBa0I7SUFDbEIsWUFBWTtJQUNaLGdCQUFnQjtBQUNwQiIsImZpbGUiOiJzcmMvYXBwL2NvbXBvbmVudHMvcmVnaXN0cmF0aW9uL3JlZ2lzdHJhdGlvbi5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLnJlZ2lzdHJhdGlvbkRpdntcclxuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxufVxyXG4udGl0bGV7XHJcbiAgICBmb250LXNpemU6IDMycHg7XHJcbiAgICBtYXJnaW4tYm90dG9tOiAxMDBweDtcclxufVxyXG5pbnB1dHtcclxuICAgIGRpc3BsYXk6IHVuc2V0O1xyXG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xyXG4gICAgd2lkdGg6IDMwMHB4O1xyXG4gICAgbWFyZ2luLXRvcDogMTBweDtcclxufSJdfQ== */");

/***/ }),

/***/ "./src/app/components/registration/registration.component.ts":
/*!*******************************************************************!*\
  !*** ./src/app/components/registration/registration.component.ts ***!
  \*******************************************************************/
/*! exports provided: RegistrationComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RegistrationComponent", function() { return RegistrationComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/Services/users.service */ "./src/app/Services/users.service.ts");




let RegistrationComponent = class RegistrationComponent {
    constructor(router, usersService) {
        this.router = router;
        this.usersService = usersService;
        this.user = usersService.initializeUser();
    }
    ngOnInit() {
    }
    signUp() {
        console.log(this.user);
        this.usersService.signUp(this.user);
    }
    signIn() {
        this.router.navigate(['/authorization']);
    }
};
RegistrationComponent.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] },
    { type: src_app_Services_users_service__WEBPACK_IMPORTED_MODULE_3__["UsersService"] }
];
RegistrationComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-registration',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./registration.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/registration/registration.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./registration.component.css */ "./src/app/components/registration/registration.component.css")).default]
    })
], RegistrationComponent);



/***/ }),

/***/ "./src/app/components/user-profile-posts/user-profile-posts.component.css":
/*!********************************************************************************!*\
  !*** ./src/app/components/user-profile-posts/user-profile-posts.component.css ***!
  \********************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = (".userPosts{\r\n  margin-top: 10px;\r\n}\r\n.writePostTitle{\r\n  display: block;\r\n  border-bottom: 1px solid var(--second-background-color);\r\n  margin-bottom: 0px;\r\n}\r\n.writePost{\r\n  border: 1px solid var(--second-background-color);\r\n  width: 600px;\r\n  height: 255px;\r\n  border-radius: 10px;\r\n}\r\n.writePostText{\r\n  background: var(--second-background-color);\r\n  border: none;\r\n  color: var(--font-color);\r\n  height: 150px;\r\n  resize: none;\r\n}\r\n.addMediaButton{\r\n  display: block;\r\n  width: 190px;\r\n  text-align: center;\r\n  margin-bottom: 20px;\r\n  float: left;\r\n}\r\n.sendPostButton{\r\n  display: block;\r\n  width: 150px;\r\n  text-align: center;\r\n  margin-bottom: 20px;\r\n  float: right;\r\n}\r\n.errorMessage{\r\n  color: red;\r\n}\r\n.readPosts{\r\n  margin-top: 20px;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29tcG9uZW50cy91c2VyLXByb2ZpbGUtcG9zdHMvdXNlci1wcm9maWxlLXBvc3RzLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSxnQkFBZ0I7QUFDbEI7QUFDQTtFQUNFLGNBQWM7RUFDZCx1REFBdUQ7RUFDdkQsa0JBQWtCO0FBQ3BCO0FBQ0E7RUFDRSxnREFBZ0Q7RUFDaEQsWUFBWTtFQUNaLGFBQWE7RUFDYixtQkFBbUI7QUFDckI7QUFDQTtFQUNFLDBDQUEwQztFQUMxQyxZQUFZO0VBQ1osd0JBQXdCO0VBQ3hCLGFBQWE7RUFDYixZQUFZO0FBQ2Q7QUFDQTtFQUNFLGNBQWM7RUFDZCxZQUFZO0VBQ1osa0JBQWtCO0VBQ2xCLG1CQUFtQjtFQUNuQixXQUFXO0FBQ2I7QUFDQTtFQUNFLGNBQWM7RUFDZCxZQUFZO0VBQ1osa0JBQWtCO0VBQ2xCLG1CQUFtQjtFQUNuQixZQUFZO0FBQ2Q7QUFDQTtFQUNFLFVBQVU7QUFDWjtBQUNBO0VBQ0UsZ0JBQWdCO0FBQ2xCIiwiZmlsZSI6InNyYy9hcHAvY29tcG9uZW50cy91c2VyLXByb2ZpbGUtcG9zdHMvdXNlci1wcm9maWxlLXBvc3RzLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIudXNlclBvc3Rze1xyXG4gIG1hcmdpbi10b3A6IDEwcHg7XHJcbn1cclxuLndyaXRlUG9zdFRpdGxle1xyXG4gIGRpc3BsYXk6IGJsb2NrO1xyXG4gIGJvcmRlci1ib3R0b206IDFweCBzb2xpZCB2YXIoLS1zZWNvbmQtYmFja2dyb3VuZC1jb2xvcik7XHJcbiAgbWFyZ2luLWJvdHRvbTogMHB4O1xyXG59XHJcbi53cml0ZVBvc3R7XHJcbiAgYm9yZGVyOiAxcHggc29saWQgdmFyKC0tc2Vjb25kLWJhY2tncm91bmQtY29sb3IpO1xyXG4gIHdpZHRoOiA2MDBweDtcclxuICBoZWlnaHQ6IDI1NXB4O1xyXG4gIGJvcmRlci1yYWRpdXM6IDEwcHg7XHJcbn1cclxuLndyaXRlUG9zdFRleHR7XHJcbiAgYmFja2dyb3VuZDogdmFyKC0tc2Vjb25kLWJhY2tncm91bmQtY29sb3IpO1xyXG4gIGJvcmRlcjogbm9uZTtcclxuICBjb2xvcjogdmFyKC0tZm9udC1jb2xvcik7XHJcbiAgaGVpZ2h0OiAxNTBweDtcclxuICByZXNpemU6IG5vbmU7XHJcbn1cclxuLmFkZE1lZGlhQnV0dG9ue1xyXG4gIGRpc3BsYXk6IGJsb2NrO1xyXG4gIHdpZHRoOiAxOTBweDtcclxuICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgbWFyZ2luLWJvdHRvbTogMjBweDtcclxuICBmbG9hdDogbGVmdDtcclxufVxyXG4uc2VuZFBvc3RCdXR0b257XHJcbiAgZGlzcGxheTogYmxvY2s7XHJcbiAgd2lkdGg6IDE1MHB4O1xyXG4gIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICBtYXJnaW4tYm90dG9tOiAyMHB4O1xyXG4gIGZsb2F0OiByaWdodDtcclxufVxyXG4uZXJyb3JNZXNzYWdle1xyXG4gIGNvbG9yOiByZWQ7XHJcbn1cclxuLnJlYWRQb3N0c3tcclxuICBtYXJnaW4tdG9wOiAyMHB4O1xyXG59Il19 */");

/***/ }),

/***/ "./src/app/components/user-profile-posts/user-profile-posts.component.ts":
/*!*******************************************************************************!*\
  !*** ./src/app/components/user-profile-posts/user-profile-posts.component.ts ***!
  \*******************************************************************************/
/*! exports provided: UserProfilePostsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserProfilePostsComponent", function() { return UserProfilePostsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var src_app_services_posts_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/services/posts.service */ "./src/app/services/posts.service.ts");



let UserProfilePostsComponent = class UserProfilePostsComponent {
    constructor(postsService) {
        this.postsService = postsService;
        this.isError = true; //есть проблемы
    }
    ngOnInit() {
        this.post = this.postsService.initializePost(this.selectedUser.id);
        this.postsService.getWallPosts(this.selectedUser.wallId).subscribe(result => this.posts = result);
    }
    createPost() {
        this.postsService.createPost(this.post, this.selectedUser.wallId);
    }
};
UserProfilePostsComponent.ctorParameters = () => [
    { type: src_app_services_posts_service__WEBPACK_IMPORTED_MODULE_2__["PostsService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], UserProfilePostsComponent.prototype, "selectedUser", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], UserProfilePostsComponent.prototype, "isMayEdit", void 0);
UserProfilePostsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-user-profile-posts',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./user-profile-posts.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/components/user-profile-posts/user-profile-posts.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./user-profile-posts.component.css */ "./src/app/components/user-profile-posts/user-profile-posts.component.css")).default]
    })
], UserProfilePostsComponent);



/***/ }),

/***/ "./src/app/services/chat-rooms.service.ts":
/*!************************************************!*\
  !*** ./src/app/services/chat-rooms.service.ts ***!
  \************************************************/
/*! exports provided: ChatRoomsService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ChatRoomsService", function() { return ChatRoomsService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let ChatRoomsService = class ChatRoomsService {
    constructor(http) {
        this.http = http;
    }
    getChatRooms(userId) {
        return this.http.get('/api/chat-room/getUserChatRooms/' + userId);
    }
    getChatRoom(roomId) {
        return this.http.get('/api/chat-room/getChatRoom/' + roomId);
    }
    getLastMessage(roomId) {
        return this.http.get('/api/chat-room/getLastMessage/' + roomId);
    }
    getUsersNames(roomId) {
        return this.http.get('/api/chat-room/getUserNames/' + roomId);
    }
};
ChatRoomsService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
ChatRoomsService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], ChatRoomsService);



/***/ }),

/***/ "./src/app/services/contents.service.ts":
/*!**********************************************!*\
  !*** ./src/app/services/contents.service.ts ***!
  \**********************************************/
/*! exports provided: ContentsService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ContentsService", function() { return ContentsService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let ContentsService = class ContentsService {
    constructor() { }
    getMedias(contentId) {
        return null;
    }
};
ContentsService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], ContentsService);



/***/ }),

/***/ "./src/app/services/message.service.ts":
/*!*********************************************!*\
  !*** ./src/app/services/message.service.ts ***!
  \*********************************************/
/*! exports provided: MessageService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessageService", function() { return MessageService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _users_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./users.service */ "./src/app/services/users.service.ts");
/* harmony import */ var _contents_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./contents.service */ "./src/app/services/contents.service.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");





let MessageService = class MessageService {
    constructor(http, usersService, contentsService) {
        this.http = http;
        this.usersService = usersService;
        this.contentsService = contentsService;
    }
    sendMessage(message, roomId) {
        return this.http.post('/hubs/chat/', message);
    }
    getMessageViewModel(message) {
        let myMessageViewModel;
        myMessageViewModel.id = message.id;
        myMessageViewModel.chatRoomId = message.id;
        myMessageViewModel.text = message.text;
        this.usersService.getUser(localStorage.getItem("userId")).subscribe(result => myMessageViewModel.sender = result);
        this.contentsService.getMedias(message.contentId).subscribe(result => myMessageViewModel.medias = result);
        return myMessageViewModel;
    }
};
MessageService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"] },
    { type: _users_service__WEBPACK_IMPORTED_MODULE_2__["UsersService"] },
    { type: _contents_service__WEBPACK_IMPORTED_MODULE_3__["ContentsService"] }
];
MessageService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], MessageService);



/***/ }),

/***/ "./src/app/services/posts.service.ts":
/*!*******************************************!*\
  !*** ./src/app/services/posts.service.ts ***!
  \*******************************************/
/*! exports provided: PostsService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PostsService", function() { return PostsService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let PostsService = class PostsService {
    constructor(http) {
        this.http = http;
    }
    initializePost(senderId) {
        return { id: null, senderId: senderId, text: "", contentId: null, likes: 0, comments: null };
    }
    getWallPosts(wallId) {
        return this.http.get('/api/post/getWallPosts/' + wallId);
    }
    createPost(post, wallId) {
        this.http.post('/api/post/createPost/' + wallId, post);
    }
};
PostsService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
PostsService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], PostsService);



/***/ }),

/***/ "./src/app/services/users.service.ts":
/*!*******************************************!*\
  !*** ./src/app/services/users.service.ts ***!
  \*******************************************/
/*! exports provided: UsersService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UsersService", function() { return UsersService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let UsersService = class UsersService {
    constructor(http) {
        this.http = http;
    }
    initializeUser() {
        return { id: null, login: null, password: null, nickName: null, isMan: true, email: null, contentId: null, wallId: null, medias: null, photoCount: null, friendsCount: null };
    }
    getUser(id) {
        return this.http.get('/api/user/' + id);
    }
    signIn(user) {
        debugger;
        return this.http.post('http://localhost:44368/api/user/login', user);
    }
    signUp(user) {
        this.http.post('/api/user/signUp', user);
    }
};
UsersService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
UsersService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], UsersService);



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

const environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm2015/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");





if (_environments_environment__WEBPACK_IMPORTED_MODULE_4__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_3__["AppModule"])
    .catch(err => console.error(err));


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\djoni\Desktop 2\StillbornSocialNetwork\Angular-StillbornSocialNetwork\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main-es2015.js.map