# RaaMS
Rules as a Micro Service. 

An AI NLP based, Cloud based modern, state-of-the-art yet simple Rule Engine and Rule Management tool, which serves Business Rules as Micro Services. Rules can be expressed in a natural language format and the engine will translate it into machine executable expressions which can be executed during runtime via serverless functions using different cloud providers like AWS, Azure etc. Takes away many pain points of configuation, storage and execution of rules.

Why as Micro Services - Rules are often based on business functions. Micro Services will allow Rules to be classified based on business capabilities. This way each Micro Service container represents RuleSets pertaining to a Business Capability. 

The essential components are:

Rule Expression: A website interface built with VueJS which allows to create and express Rules in English like language. 
Rule Configuaration and Storage: RuleSets, Rule Statements, Associated fields, and Datasources and Rule Execution functions are configuted through the Rule Configuration panel. Datasources can for Rule fields can be APIs, or other dataset formats. Rule Execution functions can be Lambda functions, AAzure functions, Or Server less functions or binaries like DLLs.

Using .Net Core ( for back-end services ) , Azure, AWS and other modern, cutting-edge technologies to develop this software. We will be soon also be using some NLP SDK ( NLTK Python ) to process the Rules expressed in natural language.
Project has just started. Contributors are most welcome.
