
//	Descrição
//	^(\w+\.\w+){1,}$ 	-> 	Valida se a string inicial com um caracter alfanumérico composto por 1 ou mais grupos de
// 					   		no mínimo 1 ou mais caracteres alfanumérico seguido de ponto (.) e 1 ou mais caracteres alfanuméricos
//	OU
//	
//	^[^\.]+$			->	Não inicia, contém ou termina com ponto (.)

string pattern = @"^(\w+\.\w+){1,}$|^[^\.]+$";