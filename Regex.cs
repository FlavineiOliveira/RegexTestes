
//	Descrição
//	^(\w+\.\w+){1,}$ 	-> 	Valida se a string inicia com um caracter alfanumérico composto por 1 ou mais grupos de
// 					   		        no mínimo 1 ou mais caracteres alfanumérico, seguido de ponto (.) e 1 ou mais caracteres alfanuméricos
//	OU
//	
//	^\w+$			        ->	Inicia e termina contendo no mínimo 1 caracter alfanumérico

string pattern = @"^(\w+\.\w+){1,}$|^\w+$";
