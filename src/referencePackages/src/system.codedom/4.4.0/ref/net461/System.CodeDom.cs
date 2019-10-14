// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("System.CodeDom")]
[assembly: AssemblyDescription("System.CodeDom")]
[assembly: AssemblyDefaultAlias("System.CodeDom")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("4.6.25519.03")]
[assembly: AssemblyInformationalVersion("4.6.25519.03 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.0.0.0")]

[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeArgumentReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeArrayCreateExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeArrayIndexerExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeAssignStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeAttachEventStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeAttributeArgument))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeAttributeArgumentCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeAttributeDeclaration))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeAttributeDeclarationCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeBaseReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeBinaryOperatorExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeBinaryOperatorType))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeCastExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeCatchClause))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeCatchClauseCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeChecksumPragma))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeComment))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeCommentStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeCommentStatementCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeCompileUnit))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeConditionStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeConstructor))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeDefaultValueExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeDelegateCreateExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeDelegateInvokeExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeDirectionExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeDirective))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeDirectiveCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeEntryPointMethod))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeEventReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeExpressionCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeExpressionStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeFieldReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeGotoStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeIndexerExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeIterationStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeLabeledStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeLinePragma))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeMemberEvent))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeMemberField))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeMemberMethod))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeMemberProperty))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeMethodInvokeExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeMethodReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeMethodReturnStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeNamespace))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeNamespaceCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeNamespaceImport))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeNamespaceImportCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeObject))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeObjectCreateExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeParameterDeclarationExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeParameterDeclarationExpressionCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodePrimitiveExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodePropertyReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodePropertySetValueReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeRegionDirective))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeRegionMode))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeRemoveEventStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeSnippetCompileUnit))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeSnippetExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeSnippetStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeSnippetTypeMember))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeStatementCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeThisReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeThrowExceptionStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTryCatchFinallyStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeConstructor))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeDeclaration))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeDeclarationCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeDelegate))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeMember))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeMemberCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeOfExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeParameter))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeParameterCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeReference))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeReferenceCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeTypeReferenceOptions))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeVariableDeclarationStatement))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.CodeVariableReferenceExpression))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.FieldDirection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.MemberAttributes))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CodeCompiler))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CodeDomProvider))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CodeGenerator))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CodeGeneratorOptions))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CodeParser))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CompilerError))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CompilerErrorCollection))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CompilerInfo))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CompilerParameters))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.CompilerResults))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.Executor))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.GeneratorSupport))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.ICodeCompiler))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.ICodeGenerator))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.ICodeParser))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.LanguageOptions))]
[assembly: TypeForwardedTo(typeof(System.CodeDom.Compiler.TempFileCollection))]
[assembly: TypeForwardedTo(typeof(Microsoft.VisualBasic.VBCodeProvider))]
[assembly: TypeForwardedTo(typeof(Microsoft.CSharp.CSharpCodeProvider))]



