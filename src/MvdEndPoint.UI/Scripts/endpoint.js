﻿!function (e) { var t, n, r, l, o; return o = ["object", "array", "number", "string", "boolean", "null"], r = function () { function t(e) { null == e && (e = {}), this.options = e } return t.prototype.htmlEncode = function (e) { return null !== e ? e.toString().replace(/&/g, "&amp;").replace(/"/g, "&quot;").replace(/</g, "&lt;").replace(/>/g, "&gt;") : "" }, t.prototype.jsString = function (e) { return e = JSON.stringify(e).slice(1, -1), this.htmlEncode(e) }, t.prototype.decorateWithSpan = function (e, t) { return '<span class="' + t + '">' + this.htmlEncode(e) + "</span>" }, t.prototype.valueToHTML = function (t, n) { var r; if (null == n && (n = 0), r = Object.prototype.toString.call(t).match(/\s(.+)]/)[1].toLowerCase(), this.options.strict && !e.inArray(r, o)) throw new Error("" + r + " is not a valid JSON value type"); return this["" + r + "ToHTML"].call(this, t, n) }, t.prototype.nullToHTML = function (e) { return this.decorateWithSpan("null", "null") }, t.prototype.undefinedToHTML = function () { return this.decorateWithSpan("undefined", "undefined") }, t.prototype.numberToHTML = function (e) { return this.decorateWithSpan(e, "num") }, t.prototype.stringToHTML = function (e) { var t, n; return /^(http|https|file):\/\/[^\s]+$/i.test(e) ? '<a href="' + this.htmlEncode(e) + '"><span class="q">"</span>' + this.jsString(e) + '<span class="q">"</span></a>' : (t = "", e = this.jsString(e), this.options.nl2br && (n = /([^>\\r\\n]?)(\\r\\n|\\n\\r|\\r|\\n)/g, n.test(e) && (t = " multiline", e = (e + "").replace(n, "$1<br />"))), '<span class="string' + t + '">"' + e + '"</span>') }, t.prototype.booleanToHTML = function (e) { return this.decorateWithSpan(e, "bool") }, t.prototype.arrayToHTML = function (e, t) { var n, r, l, o, i, s, a, p; for (null == t && (t = 0), r = !1, i = "", o = e.length, l = a = 0, p = e.length; p > a; l = ++a) s = e[l], r = !0, i += "<li>" + this.valueToHTML(s, t + 1), o > 1 && (i += ","), i += "</li>", o--; return r ? (n = 0 === t ? "" : " collapsible", '[<ul class="array level' + t + n + '">' + i + "</ul>]") : "[ ]" }, t.prototype.objectToHTML = function (e, t) { var n, r, l, o, i, s, a; null == t && (t = 0), r = !1, i = "", o = 0; for (s in e) o++; for (s in e) a = e[s], r = !0, l = this.options.escape ? this.jsString(s) : s, i += '<li><a class="prop" href="javascript:;"><span class="q">"</span>' + l + '<span class="q">"</span></a>: ' + this.valueToHTML(a, t + 1), o > 1 && (i += ","), i += "</li>", o--; return r ? (n = 0 === t ? "" : " collapsible", '{<ul class="obj level' + t + n + '">' + i + "</ul>}") : "{ }" }, t.prototype.jsonToHTML = function (e) { return '<div class="jsonview">' + this.valueToHTML(e) + "</div>" }, t }(), "undefined" != typeof module && null !== module && (module.exports = r), n = function () { function e() { } return e.bindEvent = function (e, t) { var n; return e.firstChild.addEventListener("click", function (e) { return function (n) { return e.toggle(n.target.parentNode.firstChild, t) } }(this)), n = document.createElement("div"), n.className = "collapser", n.innerHTML = t.collapsed ? "+" : "-", n.addEventListener("click", function (e) { return function (n) { return e.toggle(n.target, t) } }(this)), e.insertBefore(n, e.firstChild), t.collapsed ? this.collapse(n) : void 0 }, e.expand = function (e) { var t, n; return n = this.collapseTarget(e), "" !== n.style.display ? (t = n.parentNode.getElementsByClassName("ellipsis")[0], n.parentNode.removeChild(t), n.style.display = "", e.innerHTML = "-") : void 0 }, e.collapse = function (e) { var t, n; return n = this.collapseTarget(e), "none" !== n.style.display ? (n.style.display = "none", t = document.createElement("span"), t.className = "ellipsis", t.innerHTML = " &hellip; ", n.parentNode.insertBefore(t, n), e.innerHTML = "+") : void 0 }, e.toggle = function (e, t) { var n, r, l, o, i, s; if (null == t && (t = {}), l = this.collapseTarget(e), n = "none" === l.style.display ? "expand" : "collapse", t.recursive_collapser) { for (r = e.parentNode.getElementsByClassName("collapser"), s = [], o = 0, i = r.length; i > o; o++) e = r[o], s.push(this[n](e)); return s } return this[n](e) }, e.collapseTarget = function (e) { var t, n; return n = e.parentNode.getElementsByClassName("collapsible"), n.length ? t = n[0] : void 0 }, e }(), t = e, l = { collapse: function (e) { return "-" === e.innerHTML ? n.collapse(e) : void 0 }, expand: function (e) { return "+" === e.innerHTML ? n.expand(e) : void 0 }, toggle: function (e) { return n.toggle(e) } }, t.fn.JSONView = function () { var e, o, i, s, a, p, c; return e = arguments, null != l[e[0]] ? (a = e[0], this.each(function () { var n, r; return n = t(this), null != e[1] ? (r = e[1], n.find(".jsonview .collapsible.level" + r).siblings(".collapser").each(function () { return l[a](this) })) : n.find(".jsonview > ul > li .collapsible").siblings(".collapser").each(function () { return l[a](this) }) })) : (s = e[0], p = e[1] || {}, o = { collapsed: !1, nl2br: !1, recursive_collapser: !1, escape: !0, strict: !1 }, p = t.extend(o, p), i = new r(p), "[object String]" === Object.prototype.toString.call(s) && (s = JSON.parse(s)), c = i.jsonToHTML(s), this.each(function () { var e, r, l, o, i, s; for (e = t(this), e.html(c), l = e[0].getElementsByClassName("collapsible"), s = [], o = 0, i = l.length; i > o; o++) r = l[o], "LI" === r.parentNode.nodeName ? s.push(n.bindEvent(r.parentNode, p)) : s.push(void 0); return s })) } }(jQuery);


$(function () {
    hljs.initHighlightingOnLoad();    
    $('textarea').on('tbwblur', function(e) {
        $(e.currentTarget).trigger('blur');
    }); 
});



function DataToString(target, json) {
    $(target).JSONView(JSON.stringify(json));
}

