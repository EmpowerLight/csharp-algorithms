using Algorithms.Stack;

StaticStackOperation stack = new StaticStackOperation(7);

stack.push(1);
stack.push(2);
stack.push(3);

stack.push(4);
stack.push(5);
stack.push(6);
stack.push(7);
stack.pop();
stack.pop();
stack.pop();
stack.pop();
stack.pop();
stack.pop();
stack.pop();
stack.pop();
stack.printList();