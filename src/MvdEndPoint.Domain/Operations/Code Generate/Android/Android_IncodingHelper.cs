﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Incoding.Endpoint.Operations.Code_Generate.Android
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_IncodingHelper.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class Android_IncodingHelper : Android_IncodingHelperBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("package ");
            
            #line 3 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_IncodingHelper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(@".Incoding;

import android.content.Context;
import android.content.SharedPreferences;
import android.preference.PreferenceManager;

import org.apache.http.Header;
import org.apache.http.HttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.mime.HttpMultipartMode;
import org.apache.http.entity.mime.MultipartEntityBuilder;
import org.apache.http.entity.mime.content.ByteArrayBody;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.util.EntityUtils;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.HashMap;
import java.util.Map.Entry;

public class IncodingHelper {

    static String url = """);
            
            #line 32 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_IncodingHelper.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Url));
            
            #line default
            #line hidden
            this.Write("\" ;\r\n\tpublic static String ToValue(Object ob) throws UnsupportedEncodingException" +
                    " {\r\n\t\tif(ob instanceof java.util.Date)\r\n\t\t\treturn new SimpleDateFormat(\"dd/MM/yy" +
                    "yy\").format(ob);\r\n\t\t\t\t\r\n\t\treturn String.valueOf(ob);\r\n\t}\r\n\t\r\n\t\r\n    public stati" +
                    "c void Verify(JSONObject result) throws JSONException, ModelStateException {\r\n  " +
                    "      if (!result.getBoolean(\"success\")) {\r\n            JSONArray errors = resul" +
                    "t.isNull(\"data\") ? new JSONArray() : result.getJSONArray(\"data\");\r\n            J" +
                    "sonModelStateData[] state = new JsonModelStateData[errors.length()];\r\n          " +
                    "  for (int i = 0; i < errors.length(); i++) {\r\n                JSONObject itemEr" +
                    "ror = errors.getJSONObject(i);\r\n                JsonModelStateData jsonModelStat" +
                    "eData = new JsonModelStateData();\r\n                jsonModelStateData.errorMessa" +
                    "ge = itemError.getString(\"errorMessage\");\r\n                jsonModelStateData.is" +
                    "Valid = itemError.getBoolean(\"isValid\");\r\n                jsonModelStateData.nam" +
                    "e = itemError.getString(\"name\");\r\n                state[i] = jsonModelStateData;" +
                    "\r\n            }\r\n            throw new ModelStateException(state);\r\n        }\r\n " +
                    "   }\r\n\r\n    public static java.util.Date getDate(String dateAsString) throws Par" +
                    "seException {\r\n        return new SimpleDateFormat(\"yyyy-MM-dd\'T\'HH:mm:ss\").pars" +
                    "e(dateAsString);\r\n    }\r\n\r\n\r\n    public static String Execute(Context context, b" +
                    "oolean isPost, String type, HashMap<String,Object> parameters) throws IOExceptio" +
                    "n {\r\n        HttpResponse response = null;\r\n        try {\r\n            String ur" +
                    "l = IncodingHelper.url + type;\r\n            SharedPreferences preferences = Pref" +
                    "erenceManager.getDefaultSharedPreferences(context);\r\n\r\n            if (isPost) {" +
                    "\r\n                HttpPost http = new HttpPost(url);\r\n                http.setHe" +
                    "ader(\"Content-Type\", \"multipart/form-data; boundary=----WebKitFormBoundaryEk4quB" +
                    "tC5W6dT4RW\");\r\n                http.setHeader(\"Cookie\",  preferences.getString(\"" +
                    "Set-Cookie\", \"Set-Cookie\"));\r\n                http.setHeader(\"X-Requested-With\"," +
                    " \"XMLHttpRequest\");\r\n                MultipartEntityBuilder entity = MultipartEn" +
                    "tityBuilder.create();\r\n                entity.setBoundary(\"----WebKitFormBoundar" +
                    "yEk4quBtC5W6dT4RW\");\r\n                entity.setMode(HttpMultipartMode.BROWSER_C" +
                    "OMPATIBLE);\r\n                for (Entry<String, Object> entry : parameters.entry" +
                    "Set()) {\r\n                    if (entry.getValue() instanceof byte[]) {\r\n       " +
                    "                 entity.addPart(entry.getKey(), new ByteArrayBody((byte[]) entry" +
                    ".getValue(), \"filename\"));\r\n                    } else if (entry.getValue() inst" +
                    "anceof String[]) {\r\n                        String[] valueAsArray = (String[]) e" +
                    "ntry.getValue();\r\n                        for (String item : valueAsArray) {\r\n  " +
                    "                          entity.addTextBody(entry.getKey(), ToValue(item));\r\n  " +
                    "                      }\r\n                    } else\r\n                        try" +
                    " {                            \r\n                            entity.addTextBody(e" +
                    "ntry.getKey(), ToValue(entry.getValue()));\r\n                        } catch (Exc" +
                    "eption e) {\r\n                            e.printStackTrace();\r\n                 " +
                    "       }\r\n\r\n                }\r\n                http.setEntity(entity.build());\r\n" +
                    "\r\n                response = new DefaultHttpClient().execute(http);\r\n           " +
                    " } else {\r\n\r\n                HttpGet http = new HttpGet(url + \"?\" + getQuery(par" +
                    "ameters));\r\n                http.setHeader(\"Cookie\", preferences.getString(\"Set-" +
                    "Cookie\", \"Set-Cookie\"));\r\n                http.setHeader(\"X-Requested-With\", \"XM" +
                    "LHttpRequest\");\r\n                response = new DefaultHttpClient().execute(http" +
                    ");\r\n            }\r\n\r\n            Header[] cookies = response.getHeaders(\"Set-Coo" +
                    "kie\");\r\n            if (cookies != null && cookies.length != 0) {\r\n             " +
                    "   SharedPreferences.Editor edit = preferences.edit();\r\n                String c" +
                    "ombineCookie = preferences.getString(\"Set-Cookie\", \"Set-Cookie\");\r\n             " +
                    "   for (Header header : cookies)\r\n                    combineCookie += header.ge" +
                    "tValue() + \";\";\r\n                edit.putString(\"Set-Cookie\", combineCookie);\r\n " +
                    "               edit.commit();\r\n            }\r\n            return EntityUtils.toS" +
                    "tring(response.getEntity());\r\n        }catch(Exception e){\r\n            String s" +
                    " = \"{\\\"success\\\":false,\\\"data\\\":[{\\\"name\\\":\\\"Network\\\",\\\"isValid\\\":false,\\\"error" +
                    "Message\\\":\\\"!\\\"}],\\\"redirectTo\\\":\\\"\\\"}\";\r\n            s = s.replace(\"!\",e.getMes" +
                    "sage().replace(\"\\\"\",\"\'\"));\r\n            return s;\r\n        }\r\n\r\n    }\r\n\r\n    pri" +
                    "vate static String getQuery(HashMap<String, Object> params) throws UnsupportedEn" +
                    "codingException {\r\n        StringBuilder result = new StringBuilder();\r\n        " +
                    "boolean first = true;\r\n\r\n        for(Entry<String, Object> entry : params.entryS" +
                    "et()) {\r\n            if (first)\r\n                first = false;\r\n            els" +
                    "e\r\n                result.append(\"&\");\r\n\r\n            result.append(URLEncoder.e" +
                    "ncode(entry.getKey(), \"UTF-8\"));\r\n            result.append(\"=\");\r\n            r" +
                    "esult.append(URLEncoder.encode(ToValue(entry.getValue()), \"UTF-8\"));\r\n        }\r" +
                    "\n\r\n        return result.toString();\r\n    }\r\n\r\n\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_IncodingHelper.tt"

private string _NamespaceField;

/// <summary>
/// Access the Namespace parameter of the template.
/// </summary>
private string Namespace
{
    get
    {
        return this._NamespaceField;
    }
}

private string _UrlField;

/// <summary>
/// Access the Url parameter of the template.
/// </summary>
private string Url
{
    get
    {
        return this._UrlField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool NamespaceValueAcquired = false;
if (this.Session.ContainsKey("Namespace"))
{
    this._NamespaceField = ((string)(this.Session["Namespace"]));
    NamespaceValueAcquired = true;
}
if ((NamespaceValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Namespace");
    if ((data != null))
    {
        this._NamespaceField = ((string)(data));
    }
}
bool UrlValueAcquired = false;
if (this.Session.ContainsKey("Url"))
{
    this._UrlField = ((string)(this.Session["Url"]));
    UrlValueAcquired = true;
}
if ((UrlValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Url");
    if ((data != null))
    {
        this._UrlField = ((string)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class Android_IncodingHelperBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
