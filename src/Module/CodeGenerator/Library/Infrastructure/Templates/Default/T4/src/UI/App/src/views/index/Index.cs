// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 16.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Nm.Module.CodeGenerator.Infrastructure.Templates.Default.T4.src.UI.App.src.views.index
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class Index : IndexBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<template>\r\n  <");
            
            #line 3 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-container>\r\n    <");
            
            #line 4 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-list ref=\"list\" v-bind=\"list\">\r\n      <!--查询条件-->\r\n      <template v-slot:queryb" +
                    "ar>\r\n");
            
            #line 7 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
    foreach(var p in _class.QueryModelPropertyList){ 
            
            #line default
            #line hidden
            this.Write("        <el-form-item label=\"");
            
            #line 8 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Remarks));
            
            #line default
            #line hidden
            this.Write("：\" prop=\"");
            
            #line 8 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.CamelName));
            
            #line default
            #line hidden
            this.Write("\">\r\n          <el-input v-model=\"list.model.");
            
            #line 9 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.CamelName));
            
            #line default
            #line hidden
            this.Write("\" clearable/>\r\n        </el-form-item>\r\n");
            
            #line 11 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
    } 
            
            #line default
            #line hidden
            this.Write("      </template>\r\n\r\n      <!--按钮-->\r\n      <template v-slot:querybar-buttons>\r\n " +
                    "       <");
            
            #line 16 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-button-has :options=\"buttons.add\" @click=\"add(total)\" />\r\n      </template>\r\n\r\n " +
                    "     <!--自定义列-->\r\n      <!-- <template v-slot:col-name=\"{row}\">\r\n        <");
            
            #line 21 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-button :text=\"row.name\" type=\"text\" />\r\n      </template> -->\r\n\r\n      <!--操作列--" +
                    ">\r\n      <template v-slot:col-operation=\"{row}\">\r\n        <");
            
            #line 26 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-button-has :options=\"buttons.edit\" @click=\"edit(row)\" />\r\n        <");
            
            #line 27 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-button-delete :options=\"buttons.del\" :id=\"row.id\" :action=\"removeAction\" @succes" +
                    "s=\"refresh\"/>\r\n      </template>\r\n    </");
            
            #line 29 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-list>\r\n\r\n    <!--添加-->\r\n    <add-page :visible.sync=\"dialog.add\" @success=\"refre" +
                    "sh\"/>\r\n    <!--编辑-->\r\n    <edit-page :id=\"curr.id\" :visible.sync=\"dialog.edit\" @" +
                    "success=\"refresh\"/>\r\n  </");
            
            #line 35 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-container>\r\n</template>\r\n<script>\r\nimport api from \'../../../api/");
            
            #line 38 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write(@"'
import page from './page'
import cols from './cols'
import AddPage from '../components/add'
import EditPage from '../components/edit'

export default {
  name: page.name,
  components: { AddPage, EditPage },
  data () {
    return {
      curr: { id: '' },
      list: {
        title: page.title,
        cols,
        action: api.query,
        model: {
");
            
            #line 55 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
    for(var i=0;i<_class.QueryModelPropertyList.Count;i++){ var p=_class.QueryModelPropertyList[i]; 
            
            #line default
            #line hidden
            this.Write("          /** ");
            
            #line 56 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Remarks));
            
            #line default
            #line hidden
            this.Write(" */\r\n          ");
            
            #line 57 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.CamelName));
            
            #line default
            #line hidden
            this.Write(": \'\'");
            
            #line 57 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i < _class.QueryModelPropertyList.Count-1 ? "," : ""));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 58 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\src\views\index\Index.tt"
    } 
            
            #line default
            #line hidden
            this.Write(@"        }
      },
      removeAction: api.remove,
      dialog: {
        add: false,
        edit: false
      },
      buttons: page.buttons
    }
  },
  methods: {
    refresh () {
      this.$refs.list.refresh()
    },
    add () {
      this.dialog.add = true
    },
    edit (row) {
      this.curr = row
      this.dialog.edit = true
    }
  }
}
</script>
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class IndexBase
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
