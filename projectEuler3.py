number = int(input("Enter any number: "))
factors = []

for i in range(1, number + 1):
    if ((number % i == 0) :
            factors.append(i) #finds all factors and adds to list

i = 0
primes = []

sizeOfList = len(factors)

while i < sizeOfList:
    x = factors[i]

    for num in range(2, x): #ignores non-prime factors
        if (x % num == 0):
            break
    else:
        primes.append(x) #selects prime factors and adds to new list

    i = i + 1

print(max(primes)) #chooses largest prime number in list
