import{c as r,e as n,f,h as i}from"../../../_chunks/chunk-CFICWFWM.js";var L=n(i(),1);var v=n(i(),1);var D=n(i(),1),R=(t=>(t[t.Male=1]="Male",t[t.Female=2]="Female",t))(R||{});D.Decorators.registerEnumType(R,"MySereneApp.Modules.EmployeeManagement.Employees.EmployeeGender");var d=class d extends v.ColumnsBase{};r(d,"EmployeesColumns"),d.columnsKey="EmployeeManagement.Employees",d.Fields=(0,v.fieldsProxy)();var E=d;var e=n(i(),1);var p=class p extends e.PrefixedContext{constructor(c){if(super(c),!p.init){p.init=!0;var t=e.StringEditor,y=e.EnumEditor,S=e.MultipleImageUploadEditor,C=e.DateEditor,M=e.BooleanEditor;(0,e.initFormType)(p,["FirstName",t,"LastName",t,"Gender",y,"Certificates",S,"BirthDate",C,"IsActive",M])}}};r(p,"EmployeesForm"),p.formKey="EmployeeManagement.Employees";var u=p;var q=n(i(),1);var o=class o{};r(o,"EmployeesRow"),o.idProperty="EmployeeId",o.nameProperty="FirstName",o.localTextPrefix="EmployeeManagement.Employees",o.deletePermission="Administration:General",o.insertPermission="Administration:General",o.readPermission="Administration:General",o.updatePermission="Administration:General",o.Fields=(0,q.fieldsProxy)();var m=o;var w=n(i(),1),l;(t=>(t.baseUrl="EmployeeManagement/Employees",t.Methods={Create:"EmployeeManagement/Employees/Create",Update:"EmployeeManagement/Employees/Update",Delete:"EmployeeManagement/Employees/Delete",Retrieve:"EmployeeManagement/Employees/Retrieve",List:"EmployeeManagement/Employees/List"},["Create","Update","Delete","Retrieve","List"].forEach(y=>{t[y]=function(S,C,M){return(0,w.serviceRequest)(t.baseUrl+"/"+y,S,C,M)}})))(l||(l={}));var x=n(i(),1);var g=n(i(),1);var s=class extends g.EntityDialog{constructor(){super(...arguments);this.form=new u(this.idPrefix)}getFormKey(){return u.formKey}getRowDefinition(){return m}getService(){return l.baseUrl}};r(s,"EmployeesDialog"),s=f([g.Decorators.registerClass("MySereneApp.EmployeeManagement.EmployeesDialog")],s);var a=class extends x.EntityGrid{getColumnsKey(){return E.columnsKey}getDialogType(){return s}getRowDefinition(){return m}getService(){return l.baseUrl}constructor(c){super(c)}};r(a,"EmployeesGrid"),a=f([x.Decorators.registerClass("MySereneApp.EmployeeManagement.EmployeesGrid")],a);function A(){(0,L.initFullHeightGridPage)(new a($("#GridDiv")).element)}r(A,"pageInit");export{A as default};
//# sourceMappingURL=EmployeesPage.js.map