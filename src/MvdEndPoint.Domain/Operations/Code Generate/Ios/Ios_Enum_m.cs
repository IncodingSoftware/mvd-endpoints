﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MvdEndPoint.Domain.Operations.Code_Generate.Ios
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Incoding.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class Ios_Enum_m : Ios_Enum_mBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("#import \"IncodingHelper.h\"\r\n\r\n@implementation ");
            
            #line 16 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 17 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
 foreach(var prop in Properties) { 
            
            #line default
            #line hidden
            this.Write("\t@synthesize ");
            
            #line 18 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            this.Write(";    \r\n");
            
            #line 19 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
 } 
            
            #line default
            #line hidden
            
            #line 20 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
 if(IsQuery){
            
            #line default
            #line hidden
            this.Write("-(void)on:(Success");
            
            #line 21 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(")success\r\n");
            
            #line 22 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}else{
            
            #line default
            #line hidden
            this.Write("-(void)on:(Success");
            
            #line 23 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(")success error:(Error");
            
            #line 23 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(")error\r\n");
            
            #line 24 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
    } 
            
            #line default
            #line hidden
            this.Write("{    \r\n    NSString *request =  [NSString stringWithFormat:@\"incType=%@");
            
            #line 26 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
 foreach(var prop in Properties) {
            
            #line default
            #line hidden
            this.Write("&");
            
            #line 26 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            this.Write("=%@");
            
            #line 26 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}
            
            #line default
            #line hidden
            this.Write("\",\r\n                         @\"");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Type));
            
            #line default
            #line hidden
            this.Write("\" ");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
 foreach(var prop in Properties) {
            
            #line default
            #line hidden
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
if(prop.IsBool){
            
            #line default
            #line hidden
            this.Write(",self.");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            this.Write(" ? @\"true\" : @\"false\"");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}else{
            
            #line default
            #line hidden
            this.Write(",self.");
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}
            
            #line default
            #line hidden
            
            #line 27 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}
            
            #line default
            #line hidden
            this.Write("]; \r\n     ");
            
            #line 28 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
if(IsImage){
            
            #line default
            #line hidden
            this.Write("   \r\n[[IncodingHelper sharedInstance] download:request type:@\"QueryToFile\" done:^" +
                    "(UIImage *result){        dispatch_async(dispatch_get_main_queue(), ^{ success(r" +
                    "esult); });        }}];\r\n     ");
            
            #line 30 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}else{
            
            #line default
            #line hidden
            this.Write("[[IncodingHelper sharedInstance] execute:request type:@\"");
            
            #line 31 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Method));
            
            #line default
            #line hidden
            this.Write("\" done:^(NSDictionary *result){\r\n        dispatch_async(dispatch_get_main_queue()" +
                    ", ^{\r\n             NSNumber *isSuccess = result[@\"success\"];\r\n             if(is" +
                    "Success == [NSNumber numberWithBool:YES])\r\n             {\r\n                 succ" +
                    "ess([");
            
            #line 36 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Response));
            
            #line default
            #line hidden
            this.Write("  create:result[@\"data\"]]);\r\n             }\r\n             else\r\n             {\r\n " +
                    "            ");
            
            #line 40 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
if(IsQuery){
            
            #line default
            #line hidden
            this.Write("                [NSException raise:@\"Invalid foo value\" format:@\"foo of %d is inv" +
                    "alid\",result[@\"data\"] ];\r\n             ");
            
            #line 42 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}else{ 
            
            #line default
            #line hidden
            this.Write("                error([ModelStateException create:result[@\"data\"]]);\r\n           " +
                    "  ");
            
            #line 44 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}
            
            #line default
            #line hidden
            this.Write("             }});        \r\n    }];\r\n");
            
            #line 47 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"
}
            
            #line default
            #line hidden
            this.Write("}\r\n@end\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Workspace\mvd-endpoints\src\MvdEndPoint.Domain\Operations\Code Generate\Ios\Ios_Enum_m.tt"

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

private string _MethodField;

/// <summary>
/// Access the Method parameter of the template.
/// </summary>
private string Method
{
    get
    {
        return this._MethodField;
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

private bool _IsImageField;

/// <summary>
/// Access the IsImage parameter of the template.
/// </summary>
private bool IsImage
{
    get
    {
        return this._IsImageField;
    }
}

private global::System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQuery.Response> _PropertiesField;

/// <summary>
/// Access the Properties parameter of the template.
/// </summary>
private global::System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQuery.Response> Properties
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
bool TypeValueAcquired = false;
if (this.Session.ContainsKey("Type"))
{
    if ((typeof(string).IsAssignableFrom(this.Session["Type"].GetType()) == false))
    {
        this.Error("The type \'System.String\' of the parameter \'Type\' did not match the type of the da" +
                "ta passed to the template.");
    }
    else
    {
        this._TypeField = ((string)(this.Session["Type"]));
        TypeValueAcquired = true;
    }
}
if ((TypeValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Type");
    if ((data != null))
    {
        if ((typeof(string).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.String\' of the parameter \'Type\' did not match the type of the da" +
                    "ta passed to the template.");
        }
        else
        {
            this._TypeField = ((string)(data));
        }
    }
}
bool MethodValueAcquired = false;
if (this.Session.ContainsKey("Method"))
{
    if ((typeof(string).IsAssignableFrom(this.Session["Method"].GetType()) == false))
    {
        this.Error("The type \'System.String\' of the parameter \'Method\' did not match the type of the " +
                "data passed to the template.");
    }
    else
    {
        this._MethodField = ((string)(this.Session["Method"]));
        MethodValueAcquired = true;
    }
}
if ((MethodValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Method");
    if ((data != null))
    {
        if ((typeof(string).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.String\' of the parameter \'Method\' did not match the type of the " +
                    "data passed to the template.");
        }
        else
        {
            this._MethodField = ((string)(data));
        }
    }
}
bool ResponseValueAcquired = false;
if (this.Session.ContainsKey("Response"))
{
    if ((typeof(string).IsAssignableFrom(this.Session["Response"].GetType()) == false))
    {
        this.Error("The type \'System.String\' of the parameter \'Response\' did not match the type of th" +
                "e data passed to the template.");
    }
    else
    {
        this._ResponseField = ((string)(this.Session["Response"]));
        ResponseValueAcquired = true;
    }
}
if ((ResponseValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Response");
    if ((data != null))
    {
        if ((typeof(string).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.String\' of the parameter \'Response\' did not match the type of th" +
                    "e data passed to the template.");
        }
        else
        {
            this._ResponseField = ((string)(data));
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
bool IsImageValueAcquired = false;
if (this.Session.ContainsKey("IsImage"))
{
    if ((typeof(bool).IsAssignableFrom(this.Session["IsImage"].GetType()) == false))
    {
        this.Error("The type \'System.Boolean\' of the parameter \'IsImage\' did not match the type of th" +
                "e data passed to the template.");
    }
    else
    {
        this._IsImageField = ((bool)(this.Session["IsImage"]));
        IsImageValueAcquired = true;
    }
}
if ((IsImageValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("IsImage");
    if ((data != null))
    {
        if ((typeof(bool).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.Boolean\' of the parameter \'IsImage\' did not match the type of th" +
                    "e data passed to the template.");
        }
        else
        {
            this._IsImageField = ((bool)(data));
        }
    }
}
bool PropertiesValueAcquired = false;
if (this.Session.ContainsKey("Properties"))
{
    if ((typeof(global::System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQuery.Response>).IsAssignableFrom(this.Session["Properties"].GetType()) == false))
    {
        this.Error("The type \'System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQ" +
                "uery.Response>\' of the parameter \'Properties\' did not match the type of the data" +
                " passed to the template.");
    }
    else
    {
        this._PropertiesField = ((global::System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQuery.Response>)(this.Session["Properties"]));
        PropertiesValueAcquired = true;
    }
}
if ((PropertiesValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Properties");
    if ((data != null))
    {
        if ((typeof(global::System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQuery.Response>).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQ" +
                    "uery.Response>\' of the parameter \'Properties\' did not match the type of the data" +
                    " passed to the template.");
        }
        else
        {
            this._PropertiesField = ((global::System.Collections.Generic.List<MvdEndPoint.Domain.GetPropertiesByTypeQuery.Response>)(data));
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
    public class Ios_Enum_mBase
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
