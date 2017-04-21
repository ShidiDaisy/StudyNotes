#Turn the words in the sowpods.txt file into a Python list.
#1. Create an empty list
wordlist = []

#2. Open sowpods.txt
f = open("sowpods.txt", "r")

#3. For each word in the file, append it to the word list
for line in f:
    line = line.strip()
    #line.strip()is a function removes all whitespace at the start and end
    wordlist.append(line)
    
#4. Close the file
f.close()

print (len(wordlist))
 

