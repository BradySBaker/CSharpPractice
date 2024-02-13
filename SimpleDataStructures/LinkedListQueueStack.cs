using System.Collections;
using System.Drawing;
using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PracticeApp {
    internal class LinkedListQueueStack {
        static void Main(string[] args) {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

        }


        public class Stack {
            private ArrayList _storage = new ArrayList();
            private int _length = 0;

            public int Length { get { return _length; } }

            public void Push(object item) {
                _storage.Add(item);
                _length++;
            }

            public object Pop() {
                int count = _storage.Count;
                if (count == 0) {
                    return null;
                }
                object element = _storage[count - 1];
                _storage.RemoveAt(_storage.Count - 1);
                _length--;
                return element;
            }

            public object Peek() {
                int count = _storage.Count;
                if (count == 0) {
                    return null;
                }
                return _storage[count - 1];
            }
        }

        public class Node {
            private object _value;
            private Node? _next;
            public object Value { get { return _value; } }
            public Node Next { set { _next = value; } get { return _next; } }

            public Node(object item) {
                _value = item;
                _next = null;
            }
        }

        public class LinkedList() {
            private Node? _head;
            private Node? _tail;

            public int Length { get; private set; }
            public Node? Head { get { return _head; } }
            public Node? Tail { get { return _tail; } }


            public void Add(object item) {
                Node newNode = new Node(item);
                if (_head == null) {
                    _head = newNode;
                    _tail = newNode;
                } else {
                    _tail!.Next = newNode;
                    _tail = _tail.Next;
                }
                Length++;
            }

            public void RemoveValue(object item) {
                Node curNode = _head;
                Node? prevNode = null;
                while (curNode != null) {
                    if (curNode.Value.Equals(item)) {
                        if (curNode.Equals(_head)) {
                            _head = curNode.Next;
                        } else {
                            prevNode!.Next = curNode.Next;
                        }
                        return;
                    }
                    prevNode = curNode;
                    curNode = curNode.Next;
                }
            }

            public object? RemoveHead() {
                if (_head != null && _head.Next != null) {
                    Node head = _head;
                    _head = _head.Next;
                    Length--;
                    return head.Value;
                } else if (_head != null) {
                     object headVal = _head.Value;
                     _head = null;
                     Length = 0;
                     return headVal;
                }
                return null;
            }

            public bool Contains(object item) {
                Node curNode = _head;
                while (curNode != null) {
                    if (curNode.Value.Equals(item)) {
                        return true;
                    }
                    curNode = curNode.Next;
                }
                return false;
            }

        }

        public class Queue {
            private LinkedList _storage = new LinkedList();
            public int Length { get { return _storage.Length; } }

            public void Enqueue(object item) {
                _storage.Add(item);
            }

            public object? Peek() {
                if (_storage.Head == null) {
                    return null;
                }
                return _storage.Head.Value;
            }

            public object? Dequeue() {
                return _storage.RemoveHead();
            }

            public bool isEmpty() {
                if (Length == 0) return true;
                return false;
            }

        }
    }

}
