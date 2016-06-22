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
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class Android_Request : Android_RequestBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("package ");
            
            #line 15 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Package));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nimport org.apache.http.HttpResponse;\r\nimport org.apache.http.util.EntityUtil" +
                    "s;\r\nimport org.json.JSONObject;\r\nimport android.content.Context;\r\nimport android" +
                    ".os.AsyncTask;\r\nimport ");
            
            #line 22 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".Incoding.ModelStateException;\r\nimport ");
            
            #line 23 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".Incoding.IncodingHelper;\r\nimport java.util.HashMap;\r\n\r\npublic class ");
            
            #line 26 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" extends AsyncTask<String, Integer, String> {\r\n\r\n    ");
            
            #line 28 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
 foreach(var pair in Properties) { 
            
            #line default
            #line hidden
            this.Write("    public ");
            
            #line 29 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Type));
            
            #line default
            #line hidden
            
            #line 29 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
 if(pair.Attributes.HasFlag(GetPropertiesQuery.Response.OfAttributes.IsArray)){
            
            #line default
            #line hidden
            this.Write("[]");
            
            #line 29 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
}
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 29 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n    ");
            
            #line 30 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
 } 
            
            #line default
            #line hidden
            this.Write("   \r\n\r\n   public java.util.HashMap<String, Object> GetParameters(Integer index) {" +
                    "\r\n\tjava.util.HashMap<String, Object> parameters = new java.util.HashMap<String, " +
                    "Object>();\t\r\n\tparameters.put(\"incTypes\",\"");
            
            #line 34 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t");
            
            #line 35 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
 foreach(var pair in Properties) { 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
 if(pair.Attributes.HasFlag(GetPropertiesQuery.Response.OfAttributes.IsCanNull)) { 
            
            #line default
            #line hidden
            this.Write(" if (this.");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(" != null) ");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    parameters.put(index == -1 ? \"");
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write("\" : String.format(\"[%s].");
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write("\", index),this.");
            
            #line 37 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pair.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n    ");
            
            #line 38 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
 } 
            
            #line default
            #line hidden
            this.Write("   \r\n\treturn parameters;\r\n   } \r\n\r\n    private Context context;\r\n\r\n    private ");
            
            #line 44 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Listener));
            
            #line default
            #line hidden
            this.Write(" listener;\r\n    \t\r\n\tpublic ");
            
            #line 46 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("(Context context) {\r\n\t\tthis.context = context;\t\t\r\n\t}\r\n\t\t\r\n\t@Override\r\n    protect" +
                    "ed void onPostExecute(String s) {\r\n        super.onPostExecute(s);\r\n        try " +
                    "{\r\n            listener.Success( ");
            
            #line 54 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Response));
            
            #line default
            #line hidden
            this.Write(@".Create(new JSONObject(s)) );
        } catch (Exception e) {
            e.printStackTrace();
        } catch (ModelStateException e) {
            listener.Error(e.getState());
        }
    }

	@Override
    protected String doInBackground(String... strings) {
        try {
		   
		    HashMap<String, Object> params = new HashMap<String, Object>();			
			String type = """);
            
            #line 67 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\t\r\n            HttpResponse response = IncodingHelper.Execute(context, true" +
                    ",\"");
            
            #line 69 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type));
            
            #line default
            #line hidden
            this.Write("\",this.GetParameters(-1));\r\n\t\t\treturn EntityUtils.toString(response.getEntity());" +
                    "\r\n\t\t\t        \r\n        } catch (Exception e) {\r\n            e.printStackTrace();" +
                    "\r\n        }\r\n        return \"\";\r\n    }\r\n\r\n    public void On(");
            
            #line 78 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Listener));
            
            #line default
            #line hidden
            this.Write(" on)\r\n    {\r\n        listener = on;\r\n        execute();\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Android\Android_Request.tt"

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

private string _ListenerField;

/// <summary>
/// Access the Listener parameter of the template.
/// </summary>
private string Listener
{
    get
    {
        return this._ListenerField;
    }
}

private string _RequestField;

/// <summary>
/// Access the Request parameter of the template.
/// </summary>
private string Request
{
    get
    {
        return this._RequestField;
    }
}

private string _ResponseField;

/// <summary>
/// Access the Response parameter of the template.
/// </summary>
private string Response
{
    get
    {
        return this._ResponseField;
    }
}

private bool _HasRequestField;

/// <summary>
/// Access the HasRequest parameter of the template.
/// </summary>
private bool HasRequest
{
    get
    {
        return this._HasRequestField;
    }
}

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

private string _PackageField;

/// <summary>
/// Access the Package parameter of the template.
/// </summary>
private string Package
{
    get
    {
        return this._PackageField;
    }
}

private string _TypeField;

/// <summary>
/// Access the Type parameter of the template.
/// </summary>
private string Type
{
    get
    {
        return this._TypeField;
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
    this._NameField = ((string)(this.Session["Name"]));
    NameValueAcquired = true;
}
if ((NameValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Name");
    if ((data != null))
    {
        this._NameField = ((string)(data));
    }
}
bool ListenerValueAcquired = false;
if (this.Session.ContainsKey("Listener"))
{
    this._ListenerField = ((string)(this.Session["Listener"]));
    ListenerValueAcquired = true;
}
if ((ListenerValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Listener");
    if ((data != null))
    {
        this._ListenerField = ((string)(data));
    }
}
bool RequestValueAcquired = false;
if (this.Session.ContainsKey("Request"))
{
    this._RequestField = ((string)(this.Session["Request"]));
    RequestValueAcquired = true;
}
if ((RequestValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Request");
    if ((data != null))
    {
        this._RequestField = ((string)(data));
    }
}
bool ResponseValueAcquired = false;
if (this.Session.ContainsKey("Response"))
{
    this._ResponseField = ((string)(this.Session["Response"]));
    ResponseValueAcquired = true;
}
if ((ResponseValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Response");
    if ((data != null))
    {
        this._ResponseField = ((string)(data));
    }
}
bool HasRequestValueAcquired = false;
if (this.Session.ContainsKey("HasRequest"))
{
    this._HasRequestField = ((bool)(this.Session["HasRequest"]));
    HasRequestValueAcquired = true;
}
if ((HasRequestValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("HasRequest");
    if ((data != null))
    {
        this._HasRequestField = ((bool)(data));
    }
}
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
bool PackageValueAcquired = false;
if (this.Session.ContainsKey("Package"))
{
    this._PackageField = ((string)(this.Session["Package"]));
    PackageValueAcquired = true;
}
if ((PackageValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Package");
    if ((data != null))
    {
        this._PackageField = ((string)(data));
    }
}
bool TypeValueAcquired = false;
if (this.Session.ContainsKey("Type"))
{
    this._TypeField = ((string)(this.Session["Type"]));
    TypeValueAcquired = true;
}
if ((TypeValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Type");
    if ((data != null))
    {
        this._TypeField = ((string)(data));
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
    public class Android_RequestBase
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
