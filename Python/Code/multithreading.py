import threading
from threading import Thread
from concurrent.futures import ThreadPoolExecutor
import time

def count(thread, min, max, result):
    print(f"Thread {thread}: started\n")

    this_list = []
    index = 0
    for i in range(min, max):
        this_list.insert(index, 1)
        index += 1

    result.insert(thread-1, this_list)
    print(f"Thread {thread}: completed")

def task(number):
    print(f"Executing new Task on thread {threading.current_thread().name[-3:]}")

    result = 0
    for i in range(number):
        result = result + i

    print(f"Result:  {result}")
    print(f"Task Executed on thread {threading.current_thread().name[-3:]}")

def thread_pool_executor():
    numbers = range(100000, 1000000, 10000)
    current_threads = threading.active_count()
    start_time = time.time()
    executor = ThreadPoolExecutor(10)
    executor.map(task, numbers)
    while threading.active_count() > current_threads:
        pass

    print("\n\nCOMPLETE\n--- Took %s seconds ---" % (time.time() - start_time))


if __name__ == "__main__":
    results = []
    threads = []

    #Method 1
    #insert 10000000 "1"
    thread1 = threading.Thread(target=count, args=(1, 0, 10000000, results))
    thread2 = threading.Thread(target=count, args=(2, 0, 1000000, results))
    '''
    thread1.start()
    thread2.start()

    thread1.join()
    thread2.join()
    '''
    #Method 2
    '''
    for i in range(3, 7):
        threads.append(Thread(target=count, args=(i, 0, 10000000*i, results)))

    for thread in threads:
        thread.start()

    for thread in threads:
        thread.join()
    print(f"\n{len(results[0])}")
    #results show that which thread completed first
    '''
    #Method 3: Using ThreadPoolExecutor to create thread
    thread_pool_executor()

