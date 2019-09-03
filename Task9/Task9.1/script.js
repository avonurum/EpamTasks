var separators = [ " ","\t","?", "!", ":", ";", ",", "."];
function reduceLetters(sentence)
{
	var letters = {};
    var words = sentence.split(' ');
	for(i=0;i<words.length;i++)
	{
		var word = words[i].split('');
		for(j=0;j<word.length;j++)
		{
			if(!letters[word[j]] && separators.indexOf(word[i])==-1 && -1!=word.indexOf(word[j].toLowerCase(),j+1))
			{
				letters[word[j]]=1;
			}
		}
			}
			return sentence.split('').filter(function(item){ return !letters[item];}).join('');
}
		
function startReducing()
{
	if(document.getElementById("inputString").value!=null)
	document.getElementById("output").innerText=reduceLetters(document.getElementById("inputString").value);
}
	