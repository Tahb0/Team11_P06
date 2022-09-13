' ***************************************************************** 
' Team Number: 11 
' Team Member 1 Details: Matlhoko, T (217026727) 
' Team Member 2 Details: MAHLAKWANA MJ (222137338) 
' Team Member 3 Details: Chaza, MC (222004099) 
' Team Member 4 Details: MAHLALELA LO(222221642) 
' Practical: Team Project 
' Class name: (HIV) 
' *****************************************************************
'option  statements
option Strict on 
option Explicit on 
option infer off 

Public Class HIV
Inherits Disease
'attributes 
    End Sub

'Property methods 
public Property cd4_count as integer
get
return _CD4_COUNT
end get 
set (value as integer)
_CD4_COUNT=value
end set 

public Property typeofhiv as integer
get
return _typeofHIV
end get
set(value as integer)
_typeofHIV=value
end set 


' function to determine type of treatment 
public overides function  DetermineTreatment() as String
   dim answer as String
   if cd4_count< 200 Then
      answer="ANTIRETROVIRAL THERAPY"
      else 
      if cd4_count>500 and <1500 then 
      answer="SHOTS"
      END IF 
    END IF 
    return answer
end function 
      
'function to determine the treatment plan 

end class 