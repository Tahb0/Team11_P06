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

'derived class ikn herfiting attributes and methods from the abstract class
    Inherits desease 
    
    'attributes 
    private _numHiv as integer 
    Private _CD4_COUNT AS integer 
    private _typeofHIV as Integer 

' Constructor 
    Public Sub New(numIll As Integer, numCured As Integer,
                   numDied As Integer)
        MyBase.New(numIll, numCured, numDied)
    End Sub

'Property methods 

 public property numhiv as integer
 get 
  return _numHiv
  end get 
   set(value as integer)
   _numHiv=value 
   end set
   end property

 public Property cd4_count as integer
 get
  return _CD4_COUNT
 end get 
set (value as integer)
  _CD4_COUNT=value
end set 
end property

public Property typeofhiv as integer
get
   return _typeofHIV
end get
set(value as integer)
   _typeofHIV=value
end set 
end property

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
      
'function to calculate average cd4count of patient
public function CalcTotal() as integer 
    dim average_count as double    
    average_count=_CD4_COUNT/_numHiv
return average_count
end function
   
end class 