﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhoLockItGUI.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WhoLockItGUI.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Usage に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ArgsErrorCaption {
            get {
                return ResourceManager.GetString("ArgsErrorCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Drag &amp; Drop files or directories to this exe file. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ArgsErrorMessage {
            get {
                return ResourceManager.GetString("ArgsErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   File に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string File {
            get {
                return ResourceManager.GetString("File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Not Locked に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string NotLockedCaption {
            get {
                return ResourceManager.GetString("NotLockedCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   There are no locked files. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string NotLockedMessageMulti {
            get {
                return ResourceManager.GetString("NotLockedMessageMulti", resourceCulture);
            }
        }
        
        /// <summary>
        ///   This file is not locked. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string NotLockedMessageSingle {
            get {
                return ResourceManager.GetString("NotLockedMessageSingle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   a file is locked by.. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Process {
            get {
                return ResourceManager.GetString("Process", resourceCulture);
            }
        }
        
        /// <summary>
        ///   There are some locked files に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string WindowTitle {
            get {
                return ResourceManager.GetString("WindowTitle", resourceCulture);
            }
        }
    }
}
