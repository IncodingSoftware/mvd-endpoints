﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MvdEndPoint.Domain.Operations.Code_Generate
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class Android_Response : Android_ResponseBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nimport org.json.JSONException;\r\nimport org.json.JSONObject;\t\r\n\r\n\r\n   ");
            
            #line 16 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 if(IsArray) {
            
            #line default
            #line hidden
            this.Write("import org.json.JSONArray;\r\n\t");
            
            #line 18 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } 
            
            #line default
            #line hidden
            this.Write("  \r\npublic class ");
            
            #line 19 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 20 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 if(IsQuery) { 
            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 21 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 foreach(var pair in Properties) { 
            
            #line default
            #line hidden
            this.Write("    public ");
            
            #line 22 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Value));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 22 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Key));
            
            #line default
            #line hidden
            this.Write(";\r\n    ");
            
            #line 23 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        \r\n    ");
            
            #line 24 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 if(IsArray) {
            
            #line default
            #line hidden
            this.Write("         public static ");
            
            #line 25 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("[] Create(JSONObject result) throws JSONException {     \r\n\t\t     if(result.isNull" +
                    "(\"data\"))\r\n               return new  ");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("[0];\r\n\r\n             JSONArray data = result.getJSONArray(\"data\");\r\n     \t\t int l" +
                    "ength = data.length();\r\n             ");
            
            #line 31 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("[] res = new ");
            
            #line 31 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("[length];\r\n             for (int i = 0; i < length; i++) {\r\n                 JSON" +
                    "Object item = data.getJSONObject(i);\t\t  \r\n                 ");
            
            #line 34 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" response = new ");
            
            #line 34 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("();\r\n                 ");
            
            #line 35 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 foreach(var pair in Properties) { 
            
            #line default
            #line hidden
            this.Write("            response.");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Key));
            
            #line default
            #line hidden
            this.Write(" = item.");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MappingJsonMethodByType[pair.Value]));
            
            #line default
            #line hidden
            this.Write("(\"");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Key));
            
            #line default
            #line hidden
            this.Write("\");\r\n                 ");
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n                 res[i] = response;\r\n             }\t    \r\n     \t\treturn res;  " +
                    "   \r\n         } \r\n    ");
            
            #line 42 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t     public static ");
            
            #line 43 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" Create(JSONObject result) throws JSONException { \r\n\t\t     if(result.isNull(\"data" +
                    "\"))\r\n\t\t\t  return  new ");
            
            #line 45 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("();\r\n\r\n\t\t     JSONObject data = new JSONObject(result.getString(\"data\"));    \r\n\t " +
                    "        ");
            
            #line 48 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" res = new ");
            
            #line 48 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("();\r\n             ");
            
            #line 49 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 foreach(var pair in Properties) { 
            
            #line default
            #line hidden
            this.Write("             res.");
            
            #line 50 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Key));
            
            #line default
            #line hidden
            this.Write(" = data.");
            
            #line 50 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MappingJsonMethodByType[pair.Value]));
            
            #line default
            #line hidden
            this.Write("(\"");
            
            #line 50 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Key));
            
            #line default
            #line hidden
            this.Write("\");\r\n             ");
            
            #line 51 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n\t\t     return res;       \r\n\t\t  }     \r\n\t");
            
            #line 54 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } 
            
            #line default
            #line hidden
            this.Write("  \r\n");
            
            #line 55 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("    public Object data;\r\n\r\n    public static ");
            
            #line 58 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" Create(JSONObject result) throws JSONException {\r\n        ");
            
            #line 59 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" response = new ");
            
            #line 59 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("();\r\n        response.data = result.isNull(\"data\") ? null : result.get(\"data\");\r\n" +
                    "        return response;\r\n    }\r\n");
            
            #line 63 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \t                                                           \r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android_Response.tt"

private string _NameField;

/// <summary>
/// Access the Name parameter of the template.
/// </summary>
private string Name
{
    get
    {
        return this._NameField;
    }
}

private bool _IsArrayField;

/// <summary>
/// Access the IsArray parameter of the template.
/// </summary>
private bool IsArray
{
    get
    {
        return this._IsArrayField;
    }
}

private bool _IsQueryField;

/// <summary>
/// Access the IsQuery parameter of the template.
/// </summary>
private bool IsQuery
{
    get
    {
        return this._IsQueryField;
    }
}

private global::System.Collections.Generic.Dictionary<string,string> _PropertiesField;

/// <summary>
/// Access the Properties parameter of the template.
/// </summary>
private global::System.Collections.Generic.Dictionary<string,string> Properties
{
    get
    {
        return this._PropertiesField;
    }
}

private global::System.Collections.Generic.Dictionary<string,string> _MappingJsonMethodByTypeField;

/// <summary>
/// Access the MappingJsonMethodByType parameter of the template.
/// </summary>
private global::System.Collections.Generic.Dictionary<string,string> MappingJsonMethodByType
{
    get
    {
        return this._MappingJsonMethodByTypeField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool NameValueAcquired = false;
if (this.Session.ContainsKey("Name"))
{
    if ((typeof(string).IsAssignableFrom(this.Session["Name"].GetType()) == false))
    {
        this.Error("The type \'System.String\' of the parameter \'Name\' did not match the type of the da" +
                "ta passed to the template.");
    }
    else
    {
        this._NameField = ((string)(this.Session["Name"]));
        NameValueAcquired = true;
    }
}
if ((NameValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Name");
    if ((data != null))
    {
        if ((typeof(string).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.String\' of the parameter \'Name\' did not match the type of the da" +
                    "ta passed to the template.");
        }
        else
        {
            this._NameField = ((string)(data));
        }
    }
}
bool IsArrayValueAcquired = false;
if (this.Session.ContainsKey("IsArray"))
{
    if ((typeof(bool).IsAssignableFrom(this.Session["IsArray"].GetType()) == false))
    {
        this.Error("The type \'System.Boolean\' of the parameter \'IsArray\' did not match the type of th" +
                "e data passed to the template.");
    }
    else
    {
        this._IsArrayField = ((bool)(this.Session["IsArray"]));
        IsArrayValueAcquired = true;
    }
}
if ((IsArrayValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("IsArray");
    if ((data != null))
    {
        if ((typeof(bool).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.Boolean\' of the parameter \'IsArray\' did not match the type of th" +
                    "e data passed to the template.");
        }
        else
        {
            this._IsArrayField = ((bool)(data));
        }
    }
}
bool IsQueryValueAcquired = false;
if (this.Session.ContainsKey("IsQuery"))
{
    if ((typeof(bool).IsAssignableFrom(this.Session["IsQuery"].GetType()) == false))
    {
        this.Error("The type \'System.Boolean\' of the parameter \'IsQuery\' did not match the type of th" +
                "e data passed to the template.");
    }
    else
    {
        this._IsQueryField = ((bool)(this.Session["IsQuery"]));
        IsQueryValueAcquired = true;
    }
}
if ((IsQueryValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("IsQuery");
    if ((data != null))
    {
        if ((typeof(bool).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.Boolean\' of the parameter \'IsQuery\' did not match the type of th" +
                    "e data passed to the template.");
        }
        else
        {
            this._IsQueryField = ((bool)(data));
        }
    }
}
bool PropertiesValueAcquired = false;
if (this.Session.ContainsKey("Properties"))
{
    if ((typeof(global::System.Collections.Generic.Dictionary<string,string>).IsAssignableFrom(this.Session["Properties"].GetType()) == false))
    {
        this.Error("The type \'System.Collections.Generic.Dictionary<string,string>\' of the parameter " +
                "\'Properties\' did not match the type of the data passed to the template.");
    }
    else
    {
        this._PropertiesField = ((global::System.Collections.Generic.Dictionary<string,string>)(this.Session["Properties"]));
        PropertiesValueAcquired = true;
    }
}
if ((PropertiesValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Properties");
    if ((data != null))
    {
        if ((typeof(global::System.Collections.Generic.Dictionary<string,string>).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.Collections.Generic.Dictionary<string,string>\' of the parameter " +
                    "\'Properties\' did not match the type of the data passed to the template.");
        }
        else
        {
            this._PropertiesField = ((global::System.Collections.Generic.Dictionary<string,string>)(data));
        }
    }
}
bool MappingJsonMethodByTypeValueAcquired = false;
if (this.Session.ContainsKey("MappingJsonMethodByType"))
{
    if ((typeof(global::System.Collections.Generic.Dictionary<string,string>).IsAssignableFrom(this.Session["MappingJsonMethodByType"].GetType()) == false))
    {
        this.Error("The type \'System.Collections.Generic.Dictionary<string,string>\' of the parameter " +
                "\'MappingJsonMethodByType\' did not match the type of the data passed to the templ" +
                "ate.");
    }
    else
    {
        this._MappingJsonMethodByTypeField = ((global::System.Collections.Generic.Dictionary<string,string>)(this.Session["MappingJsonMethodByType"]));
        MappingJsonMethodByTypeValueAcquired = true;
    }
}
if ((MappingJsonMethodByTypeValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("MappingJsonMethodByType");
    if ((data != null))
    {
        if ((typeof(global::System.Collections.Generic.Dictionary<string,string>).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.Collections.Generic.Dictionary<string,string>\' of the parameter " +
                    "\'MappingJsonMethodByType\' did not match the type of the data passed to the templ" +
                    "ate.");
        }
        else
        {
            this._MappingJsonMethodByTypeField = ((global::System.Collections.Generic.Dictionary<string,string>)(data));
        }
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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class Android_ResponseBase
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
