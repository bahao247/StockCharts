//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickNote1 {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class EditPage : global::Xamarin.Forms.ContentPage {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry nameNoteEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry typeNoteEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry textNoteEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry remindingNoteEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.TimePicker dueTimeNotePicker;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.DatePicker dueDateNotePicker;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Switch statusNoteSwitch;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Switch doneNoteSwitch;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Switch statusNoteSwitchNone;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Switch statusNoteSwitchLow;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Switch statusNoteSwitchHigh;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Switch statusNoteSwitchUrgen;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button saveButton;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button deleteButton;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(EditPage));
            nameNoteEntry = this.FindByName<global::Xamarin.Forms.Entry>("nameNoteEntry");
            typeNoteEntry = this.FindByName<global::Xamarin.Forms.Entry>("typeNoteEntry");
            textNoteEntry = this.FindByName<global::Xamarin.Forms.Entry>("textNoteEntry");
            remindingNoteEntry = this.FindByName<global::Xamarin.Forms.Entry>("remindingNoteEntry");
            dueTimeNotePicker = this.FindByName<global::Xamarin.Forms.TimePicker>("dueTimeNotePicker");
            dueDateNotePicker = this.FindByName<global::Xamarin.Forms.DatePicker>("dueDateNotePicker");
            statusNoteSwitch = this.FindByName<global::Xamarin.Forms.Switch>("statusNoteSwitch");
            doneNoteSwitch = this.FindByName<global::Xamarin.Forms.Switch>("doneNoteSwitch");
            statusNoteSwitchNone = this.FindByName<global::Xamarin.Forms.Switch>("statusNoteSwitchNone");
            statusNoteSwitchLow = this.FindByName<global::Xamarin.Forms.Switch>("statusNoteSwitchLow");
            statusNoteSwitchHigh = this.FindByName<global::Xamarin.Forms.Switch>("statusNoteSwitchHigh");
            statusNoteSwitchUrgen = this.FindByName<global::Xamarin.Forms.Switch>("statusNoteSwitchUrgen");
            saveButton = this.FindByName<global::Xamarin.Forms.Button>("saveButton");
            deleteButton = this.FindByName<global::Xamarin.Forms.Button>("deleteButton");
        }
    }
}
