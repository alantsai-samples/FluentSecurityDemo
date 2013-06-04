#介紹
這個Project主要用來介紹如何使用Fluent Security這一個套件。詳細的訊息可以參考以下文章[連接](http://www.dotblogs.com.tw/alantsai/archive/2013/06/04/105245.aspx)

#架構和動到的頁面
使用Visual Studio 2012用Internet Application Template開啟
使用Fluent Security Pre release 2.0

Utilities/Helper下面有三個cs檔案

1. Security.cs - 設定每一頁的權限
2. AdminPolicy.cs - 自定義policy
3. AdminPolicyViolationHandler.cs - 自定義Policy Violation Handler

App_Start/FilterConfig.cs - Fluent Security增加一個Global Filter
