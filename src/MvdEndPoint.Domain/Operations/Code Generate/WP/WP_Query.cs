﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Incoding.Endpoint.Operations.Code_Generate.WP
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Incoding.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class WP_Query : WP_QueryBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Text;\r\nusing System.Collections.Generic;\r\nusing Sys" +
                    "tem.Net;\r\n using System.Threading.Tasks;\r\n\r\nnamespace ");
            
            #line 19 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Meta.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 21 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Meta.Name));
            
            #line default
            #line hidden
            this.Write(":HttpMessageBase\r\n\t{\r\n\t\t \r\n\t\t ");
            
            #line 24 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 foreach(var pair in Properties) { 
            
            #line default
            #line hidden
            this.Write("\t\t ");
            
            #line 25 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
if(IsNotifyPropertyChanged){
            
            #line default
            #line hidden
            this.Write("\t\t\t\t private ");
            
            #line 26 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Type));
            
            #line default
            #line hidden
            this.Write(" _");
            
            #line 26 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\tpublic ");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n\t\t\tget { return this._");
            
            #line 29 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write("; }\r\n\t\t\tset\r\n\t\t\t{\r\n\t\t\t\tthis._");
            
            #line 32 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n\t\t\t\tOnPropertyChanged();\r\n\t\t\t}\r\n\t\t}\r\n\t\t ");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}else{
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Type));
            
            #line default
            #line hidden
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 if(pair.Attributes.HasFlag(GetPropertiesQuery.Response.OfAttributes.IsArray)){
            
            #line default
            #line hidden
            this.Write("[]");
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(" {get;set;}\r\n\t\t");
            
            #line 38 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t ");
            
            #line 39 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 } 
            
            #line default
            #line hidden
            this.Write("   \r\n\t\t \r\n\r\n\t\tpublic class Response\r\n\t\t{\t\t  \r\n\t\t");
            
            #line 44 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 foreach(var pair in InnerResponses) { 
            
            #line default
            #line hidden
            this.Write("\t\t   public class ");
            
            #line 45 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Key));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t   {\r\n\t\t\t");
            
            #line 47 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 foreach(var prop in pair.Value) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tpublic ");
            
            #line 48 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Type));
            
            #line default
            #line hidden
            
            #line 48 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 if(prop.Attributes.HasFlag(GetPropertiesQuery.Response.OfAttributes.IsArray)){
            
            #line default
            #line hidden
            this.Write("[]");
            
            #line 48 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 48 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            this.Write(" {get;set;}\r\n\t\t\t");
            
            #line 49 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t   }        \r\n\t\t");
            
            #line 51 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 } 
            
            #line default
            #line hidden
            this.Write("  \r\n\t\t\t\t\t\t \r\n\t\t");
            
            #line 53 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 foreach(var pair in Response) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 54 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Type));
            
            #line default
            #line hidden
            
            #line 54 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 if(pair.Attributes.HasFlag(GetPropertiesQuery.Response.OfAttributes.IsArray)){
            
            #line default
            #line hidden
            this.Write("[]");
            
            #line 54 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 54 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(" {get;set;}\r\n\t\t ");
            
            #line 55 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 } 
            
            #line default
            #line hidden
            this.Write("  \r\n\r\n\t\t}\r\n\r\n\t\t public Dictionary<string, object> GetPostData()\r\n        {\r\n     " +
                    "       var postData = new Dictionary<string, object>();\r\n\t\t\tpostData.Add(\"incTyp" +
                    "es\", \"");
            
            #line 62 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Meta.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t\t");
            
            #line 63 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 foreach(var pair in Properties) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\tpostData.Add(\"");
            
            #line 64 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write("\", this.");
            
            #line 64 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(");\t\t\t             \r\n\t\t\t");
            
            #line 65 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 } 
            
            #line default
            #line hidden
            this.Write("  \r\n\t\t\treturn postData;\r\n        }\r\n\r\n\t\tpublic async void On(Action<Response");
            
            #line 69 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 if(Meta.ResponseAsArray){
            
            #line default
            #line hidden
            this.Write("[]");
            
            #line 69 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}
            
            #line default
            #line hidden
            this.Write("> onSuccess, Action<object, HttpStatusCode> onError = null, Action<ModelState[]> " +
                    "onValidation = null)\r\n\t\t{\r\n\t\t\tawait PostAwait(false, onSuccess, onError, onValid" +
                    "ation, GetPostData());\r\n\t\t}\r\n\r\n\t\tpublic Task<Response");
            
            #line 74 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 if(Meta.ResponseAsArray){
            
            #line default
            #line hidden
            this.Write("[]");
            
            #line 74 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}
            
            #line default
            #line hidden
            this.Write("> Get(Action<object, HttpStatusCode> onError = null, Action<ModelState[]> onValid" +
                    "ation = null)\r\n        {\r\n            return PostAwait<Response");
            
            #line 76 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
 if(Meta.ResponseAsArray){
            
            #line default
            #line hidden
            this.Write("[]");
            
            #line 76 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"
}
            
            #line default
            #line hidden
            this.Write(">(false, onError, onValidation, GetPostData());\r\n        }\r\n\t}\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\WP\WP_Query.tt"

private global::Incoding.Endpoint.GetMetaFromTypeQuery.Response _MetaField;

/// <summary>
/// Access the Meta parameter of the template.
/// </summary>
private global::Incoding.Endpoint.GetMetaFromTypeQuery.Response Meta
{
    get
    {
        return this._MetaField;
    }
}

private bool _IsNotifyPropertyChangedField;

/// <summary>
/// Access the IsNotifyPropertyChanged parameter of the template.
/// </summary>
private bool IsNotifyPropertyChanged
{
    get
    {
        return this._IsNotifyPropertyChangedField;
    }
}

private global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response> _PropertiesField;

/// <summary>
/// Access the Properties parameter of the template.
/// </summary>
private global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response> Properties
{
    get
    {
        return this._PropertiesField;
    }
}

private global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response> _ResponseField;

/// <summary>
/// Access the Response parameter of the template.
/// </summary>
private global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response> Response
{
    get
    {
        return this._ResponseField;
    }
}

private global::System.Collections.Generic.Dictionary<string,System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>> _InnerResponsesField;

/// <summary>
/// Access the InnerResponses parameter of the template.
/// </summary>
private global::System.Collections.Generic.Dictionary<string,System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>> InnerResponses
{
    get
    {
        return this._InnerResponsesField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool MetaValueAcquired = false;
if (this.Session.ContainsKey("Meta"))
{
    this._MetaField = ((global::Incoding.Endpoint.GetMetaFromTypeQuery.Response)(this.Session["Meta"]));
    MetaValueAcquired = true;
}
if ((MetaValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Meta");
    if ((data != null))
    {
        this._MetaField = ((global::Incoding.Endpoint.GetMetaFromTypeQuery.Response)(data));
    }
}
bool IsNotifyPropertyChangedValueAcquired = false;
if (this.Session.ContainsKey("IsNotifyPropertyChanged"))
{
    this._IsNotifyPropertyChangedField = ((bool)(this.Session["IsNotifyPropertyChanged"]));
    IsNotifyPropertyChangedValueAcquired = true;
}
if ((IsNotifyPropertyChangedValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("IsNotifyPropertyChanged");
    if ((data != null))
    {
        this._IsNotifyPropertyChangedField = ((bool)(data));
    }
}
bool PropertiesValueAcquired = false;
if (this.Session.ContainsKey("Properties"))
{
    this._PropertiesField = ((global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>)(this.Session["Properties"]));
    PropertiesValueAcquired = true;
}
if ((PropertiesValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Properties");
    if ((data != null))
    {
        this._PropertiesField = ((global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>)(data));
    }
}
bool ResponseValueAcquired = false;
if (this.Session.ContainsKey("Response"))
{
    this._ResponseField = ((global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>)(this.Session["Response"]));
    ResponseValueAcquired = true;
}
if ((ResponseValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Response");
    if ((data != null))
    {
        this._ResponseField = ((global::System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>)(data));
    }
}
bool InnerResponsesValueAcquired = false;
if (this.Session.ContainsKey("InnerResponses"))
{
    this._InnerResponsesField = ((global::System.Collections.Generic.Dictionary<string,System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>>)(this.Session["InnerResponses"]));
    InnerResponsesValueAcquired = true;
}
if ((InnerResponsesValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("InnerResponses");
    if ((data != null))
    {
        this._InnerResponsesField = ((global::System.Collections.Generic.Dictionary<string,System.Collections.Generic.List<Incoding.Endpoint.GetPropertiesQuery.Response>>)(data));
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
    public class WP_QueryBase
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
