f = open("countries.txt", "r")
#r for reading, w for writing
#We need to save our Python file in the same directory where sowpods.txt lives

#Reading the file and store the line into the list 
countries = []
for line in f:
    line = line.strip()
    #line.strip()is a function removes all whitespace at the start and end
    countries.append(line)   
f.close()
print(countries)

number_of_countries = len(countries)
print("There are " + str(number_of_countries) + " countries.")

print("There are the countries that start with T:")
for country in countries:
    if country[0] == "T":
        print(country)
        
print("There are the countries that end with land:")
for country in countries:
    if country[-4] == "l":
        if country[-3] == "a":
            if country[-2] == "n": 
                if country[-1] == "d":
                    print(country)
                    
