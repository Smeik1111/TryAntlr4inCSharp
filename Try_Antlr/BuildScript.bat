cd Grammatic
for %%f in (.\*.g4) do (
     java -cp ..\..\antlr-4.9.3-complete.jar org.antlr.v4.Tool -Dlanguage=CSharp %%f -package %%~nf -visitor -o %%~nf_Generated
)
exit 0
