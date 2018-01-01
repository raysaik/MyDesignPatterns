[1mdiff --git a/Business Rules/Rules.txt b/Business Rules/Rule1.txt[m
[1msimilarity index 100%[m
[1mrename from Business Rules/Rules.txt[m
[1mrename to Business Rules/Rule1.txt[m
[1mdiff --git a/Business Rules/Rule2.txt b/Business Rules/Rule2.txt[m
[1mnew file mode 100644[m
[1mindex 0000000..8d5e348[m
[1m--- /dev/null[m
[1m+++ b/Business Rules/Rule2.txt[m	
[36m@@ -0,0 +1 @@[m
[32m+[m[32mAll Housekeeping Staff expenses paid by CASH should not be reimbursed[m
\ No newline at end of file[m
[1mdiff --git a/Data Source/Bill_data_summary.xlsx b/Data Source/Bill_data_summary.xlsx[m
[1mindex 72e452f..f922c36 100644[m
Binary files a/Data Source/Bill_data_summary.xlsx and b/Data Source/Bill_data_summary.xlsx differ
[1mdiff --git a/Repository_Pattern.v11.suo b/Repository_Pattern.v11.suo[m
[1mindex 0296aed..7312b97 100644[m
Binary files a/Repository_Pattern.v11.suo and b/Repository_Pattern.v11.suo differ
[1mdiff --git a/Repository_Pattern_BusinessLayer/Repository_Pattern_BusinessLayer.csproj b/Repository_Pattern_BusinessLayer/Repository_Pattern_BusinessLayer.csproj[m
[1mindex 8a2c666..cc2d837 100644[m
[1m--- a/Repository_Pattern_BusinessLayer/Repository_Pattern_BusinessLayer.csproj[m
[1m+++ b/Repository_Pattern_BusinessLayer/Repository_Pattern_BusinessLayer.csproj[m
[36m@@ -42,6 +42,7 @@[m
     <Compile Include="IRule.cs" />[m
     <Compile Include="Rule1.cs" />[m
     <Compile Include="Properties\AssemblyInfo.cs" />[m
[32m+[m[32m    <Compile Include="Rule2.cs" />[m
     <Compile Include="RuleHelpers.cs" />[m
   </ItemGroup>[m
   <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />[m
[1mdiff --git a/Repository_Pattern_BusinessLayer/Rule2.cs b/Repository_Pattern_BusinessLayer/Rule2.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..eb851ed[m
[1m--- /dev/null[m
[1m+++ b/Repository_Pattern_BusinessLayer/Rule2.cs[m
[36m@@ -0,0 +1,46 @@[m
[32m+[m[32m﻿using System;[m
[32m+[m[32musing System.Collections.Generic;[m
[32m+[m[32musing System.Linq;[m
[32m+[m[32musing System.Text;[m
[32m+[m[32musing System.Threading.Tasks;[m
[32m+[m
[32m+[m[32mnamespace Repository_Pattern_BusinessLayer[m
[32m+[m[32m{[m
[32m+[m[32m    public class Rule2 : IRule[m
[32m+[m[32m    {[m
[32m+[m[32m        public string RuleName[m
[32m+[m[32m        {[m
[32m+[m[32m            get[m
[32m+[m[32m            {[m
[32m+[m[32m                return "HouseKeepingRule";[m
[32m+[m[32m            }[m
[32m+[m
[32m+[m[32m        }[m
[32m+[m
[32m+[m[32m        public string RuleDescription[m
[32m+[m[32m        {[m
[32m+[m[32m            get[m
[32m+[m[32m            {[m
[32m+[m[32m                //This should read from the rule book[m
[32m+[m[32m                return "Housekeeping reimbursement policy based on payment mode";[m
[32m+[m[32m            }[m
[32m+[m[32m        }[m
[32m+[m
[32m+[m
[32m+[m[32m        private string _grade;[m
[32m+[m[32m        private double _amount;[m
[32m+[m[32m        private string _designation;[m
[32m+[m[32m        private double _amountPaidInCash;[m
[32m+[m[32m        public double RuleImplementation(params dynamic[] param1)[m
[32m+[m[32m        {[m
[32m+[m[32m            _grade = param1[0];[m
[32m+[m[32m            _amount = param1[1];[m
[32m+[m[32m            _designation = param1[2];[m
[32m+[m[32m            _amountPaidInCash = param1[3];[m
[32m+[m[32m            if (_designation.Equals("Housekeeping")) {[m
[32m+[m[32m                _amount = _amount + _amountPaidInCash;[m
[32m+[m[32m            }[m
[32m+[m[32m            return _amount;[m
[32m+[m[32m        }[m
[32m+[m[32m    }[m
[32m+[m[32m}[m
[1mdiff --git a/Repository_Pattern_UI.Tests/Repository_Pattern_UI.Tests.csproj.user b/Repository_Pattern_UI.Tests/Repository_Pattern_UI.Tests.csproj.user[m
[1mindex 55f44b9..07dbd5b 100644[m
[1m--- a/Repository_Pattern_UI.Tests/Repository_Pattern_UI.Tests.csproj.user[m
[1m+++ b/Repository_Pattern_UI.