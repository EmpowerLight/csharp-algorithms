using Algorithms.Queue;

DynamicQueueOperation queueOperation = new DynamicQueueOperation();

queueOperation.enqueue(1);
queueOperation.enqueue(2);
queueOperation.enqueue(3);
queueOperation.enqueue(4);
queueOperation.enqueue(5);
queueOperation.enqueue(6);
queueOperation.enqueue(7);
queueOperation.dequeue();
queueOperation.dequeue();
queueOperation.printQueue();