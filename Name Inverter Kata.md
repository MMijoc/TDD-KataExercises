# Name Inverter Kata #

## Instructions ##

This kata is designed to help you learn test-first coding and refactoring.<br/><br/>
Name Inverter is a program which given a name (string) returns inverted name. (e.g. for the name "John Shepard" the inverter should return "Shepard, John")
<br/>Inverter should handel following cases:
1. Multiple whitespace characters should be removed and replaced with only one space
	- <pre>" John    Shepard  " -> "Shepard, John"</pre>
2. If there is only one name then the result is that name (without whitespace)
  	- <pre>" John    " -> "John"</pre>
3. If the name is an empty string or whitespace result is an empty string
	- <pre>"" -> ""</pre>
	- <pre>"   " -> ""</pre>
4. If the name is null program throws an exception
5. Honorifics (Mr. Mrs. ....) should be removed from the result
	- <pre>"Mr. John Shepard" -> "Shepard, John"</pre>
6. Post Nominals (Jr., Sr. Phd., ...) need to go after the name separated by a space in case there are multiple.
	- <pre>"John Shepard Jr." -> "Shepard, John Jr."</pre>
	- <pre>"John Shepard Jr. PhD." -> "Shepard, John Jr. PhD."</pre>

## Resources ##
- This Kata was taken from The Code Dojo on YouTube [Link to video](https://www.youtube.com/watch?v=bGa90QVWw0I&ab_channel=TheCodeDojo)
 
