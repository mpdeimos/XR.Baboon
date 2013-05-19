﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace covhtml {
    using System;
    
    
    public partial class ReportIndex : ReportIndexBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 2 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("<html>\n<head><title>");
            
            #line default
            #line hidden
            
            #line 3 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( this.ProjectName ));
            
            #line default
            #line hidden
            
            #line 3 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(" Code Coverage Report</title>\n<style>\nbody {\n  font-family: sans-serif;\n}\n\nth {\n  text-align: left;\n}\n</style>\n\n</head>\n<body>\n<h1>");
            
            #line default
            #line hidden
            
            #line 16 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( this.ProjectName ));
            
            #line default
            #line hidden
            
            #line 16 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</h1>\n<h2>Code Coverage</h2>\n<table>\n<tr><th>Detail</th><th>Value</th></tr>\n");
            
            #line default
            #line hidden
            
            #line 20 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"

foreach ( var k in this.metadata.Keys ) {
  if ( !k.StartsWith("match:") ) {

            
            #line default
            #line hidden
            
            #line 24 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("  <tr><td>");
            
            #line default
            #line hidden
            
            #line 24 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( k ));
            
            #line default
            #line hidden
            
            #line 24 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td><td>");
            
            #line default
            #line hidden
            
            #line 24 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( this.metadata[k] ));
            
            #line default
            #line hidden
            
            #line 24 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td></tr>\n");
            
            #line default
            #line hidden
            
            #line 25 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"

  }
}

            
            #line default
            #line hidden
            
            #line 29 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</table>\n\n<h2>Patterns</h2>\n<table>\n<tr><th style=\"width:3in\">Pattern</th><th>Lines Matched</th><th colspan=\"2\">Lines Covered</th></tr>\n");
            
            #line default
            #line hidden
            
            #line 34 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"

foreach ( var k in this.metadata.Keys ) {
  if ( k.StartsWith("match:") ) {
    var patt = this.metadata[k];
    int lines = 0;
    int hits = 0;
    LineMatchCount( patt, out lines, out hits );
    int pct = 0;
    if ( lines > 0 )
    {
      pct = (int)(100 * hits/lines );
    }
      

            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("  <tr><td>");
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patt ));
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td><td>");
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( lines ));
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td><td>");
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( hits ));
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td><td>");
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( pct ));
            
            #line default
            #line hidden
            
            #line 48 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("%</td></tr>\n");
            
            #line default
            #line hidden
            
            #line 49 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"

  }
}

            
            #line default
            #line hidden
            
            #line 53 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</table>\n\n<h2>Results</h2>\n<table>\n<tr><th></th><th>Calls</th><th>Lines</th><th>Hits</th><th>Coverage</th></tr>\n");
            
            #line default
            #line hidden
            
            #line 58 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"

foreach ( var tname in GetTypes() ) {

            
            #line default
            #line hidden
            
            #line 61 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("<tr>\n<td colspan=\"4\"><b>");
            
            #line default
            #line hidden
            
            #line 62 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( tname ));
            
            #line default
            #line hidden
            
            #line 62 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</b></td>\n<td align=\"right\">");
            
            #line default
            #line hidden
            
            #line 63 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetTypeCoverage(tname) ));
            
            #line default
            #line hidden
            
            #line 63 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("%</td>\n</tr>\n");
            
            #line default
            #line hidden
            
            #line 65 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"

  foreach ( var m in GetMembers(tname) ) {
    var cov = GetCoverage(m);
    if ( cov < 0 ) continue;

            
            #line default
            #line hidden
            
            #line 70 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("<tr>\n<td>");
            
            #line default
            #line hidden
            
            #line 71 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( m.FullMethodName ));
            
            #line default
            #line hidden
            
            #line 71 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td>\n<td align=\"right\">");
            
            #line default
            #line hidden
            
            #line 72 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( m.CallCount ));
            
            #line default
            #line hidden
            
            #line 72 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td>\n<td align=\"right\">");
            
            #line default
            #line hidden
            
            #line 73 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( m.GetLines().Length ));
            
            #line default
            #line hidden
            
            #line 73 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td>\n<td align=\"right\">");
            
            #line default
            #line hidden
            
            #line 74 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( m.GetHits() ));
            
            #line default
            #line hidden
            
            #line 74 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</td>\n<td align=\"right\">");
            
            #line default
            #line hidden
            
            #line 75 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( cov ));
            
            #line default
            #line hidden
            
            #line 75 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("%</td>\n</tr>\n<tr>\n<td colspan=\"5\"> \n<table cellpadding=\"0\" cellspacing=\"0\" style=\"width:100%\">\n<tr>\n<td style='background:green; height:16px; width:");
            
            #line default
            #line hidden
            
            #line 81 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( cov  ));
            
            #line default
            #line hidden
            
            #line 81 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("%;'></td> \n<td style='background:red; height:16px; width:");
            
            #line default
            #line hidden
            
            #line 82 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( (100 - cov) ));
            
            #line default
            #line hidden
            
            #line 82 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("%;'></td>\n</tr>\n</table>\n</td></tr>\n \n");
            
            #line default
            #line hidden
            
            #line 87 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"

  }
}

            
            #line default
            #line hidden
            
            #line 91 "/home/inb/Projects/git/XR.Baboon/cov-html/ReportIndex.tt"
            this.Write("</body>\n</html>     \n     \n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        protected virtual void Initialize() {
        }
    }
    
    public class ReportIndexBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((this.formatProvider == null)) {
                        throw new global::System.ArgumentNullException("formatProvider");
                    }
                    this.formatProvider = value;
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
