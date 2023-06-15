// See https://aka.ms/new-console-template for more information
using Composite;
using System.Xml;

Console.WriteLine("Hello, World!");
/*
 * Tree-Structure modelinde bellekte nesne saklamanız gerekiyor. Bu gereksinimi nasıl çözersiniz?
 * Linked-List
 *    Node - Element
 * 
 * Arama işlevini hızlandırmak veya bellekte scope'lar arası taşıma işlemleri için. 
 * Algoritmanın sonucu olarak kullanıyoruz.
 */
Category electronic = new Category { Name = "Elektronik" };
Composite<Category> catagoriesTree = new Composite<Category>();
var node1 = catagoriesTree.Add(electronic);
var node2 = node1.Add(new Category { Name = "computers" });
var node3 = node2.Add(new Category { Name = "Laptops" });
var node4 = node2.Add(new Category { Name = "PCs" });
var node5 = node1.Add(new Category { Name = "Home & Theatre System" });

Composite<Category>.Show(0, catagoriesTree);

XmlDocument xmlDocument = new XmlDocument();
XmlNode xmlNode = null;

