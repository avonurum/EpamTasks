            var mathOperationsRgx =  /\s*[+\-*/=]\s*/;
            var operandsRgx= /\s*[0-9\.]\s*/;
            var correctOperandRgx = /[1-9][0-9]*(\.[0-9]+)?|0\.[0-9]*[1-9]|0/g;
            var actualOperand='';
            var actualMathOperation='';
            var endOfString='=';
            var result='';
            

            function startCalculating()
            {
                alert(calculate(document.getElementById("inputData").value));
            }

            function calculate(inputD)
            {
                var string=''+inputD;
                var index = 0;
                if(mathOperationsRgx.test(string[0]))
                {
                    return "wrong sring, try again";
                }
                else
                {
                    while((index<string[index])&&operandsRgx.test(string[index]))
                    {
                        result+=string[index];
                        index++;
                    }
                    if(!result.match(correctOperandRgx))
                    {
                        return "operand is not a number";
                    }
                    else
                    {
                        result = +result;
                    }
                    while(index<string.length)
                    {
                        if(mathOperationsRgx.test(string[index]))
                        {
                            while((index<string.length)&&(mathOperationsRgx.test(string[index])))
                            {
                                actualMathOperation+=string[index];
                                index++;
                            }
                            if(actualMathOperation.length>1)
                            {
                                return "operator is not correct";
                            }
							
							if((actualMathOperation===endOfString)&&(index<string.length))
                            {
                                return "= must be the last operation and the last symbol";
                            }
                            else if((actualMathOperation===endOfString&&(index==string.length-1)))
                            {
                                return result.toFixed(2);
                            }
                        }
                        else if(operandsRgx.test(string[index]))
                        {
                            while((index<string.length)&&(operandsRgx.test(string[index])))
                            {
                                actualOperand+=string[index];
                                index++;
                            }
                            if(!actualOperand.match(correctOperandRgx))
                            {
                                return 'operand is not a number';
                            }
							else
							{
								switch(actualMathOperation)
								{
									case"+": result+=+actualOperand;break;
									case"-":result-=+actualOperand;break;
									case"*":result*=+actualOperand;break;
									case"/":result/=+actualOperand;break;
									default: return 'is not operator';
								}
								
							}
							actualOperand='';
							actualMathOperation='';
                        }
                        else
                        {
                            return 'string is not a formula';
                        }

                    }

                }
            }