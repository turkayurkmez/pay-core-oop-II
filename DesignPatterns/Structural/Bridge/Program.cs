﻿// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");
/*
 *               Report
 *              /       \
 *         Sales                  Performance
 *          / |    \               /  |    \
 *        PDF HTML  Excel      PDF  HTML    Excel
 *        
 *        
 *         Report 
 *            
 *          
 *         
 *         
 *         Bridge desen, inheritance kaosu denen yapıyı çözmek için vardır. Aslında özellik olması gereken bir kavramı inherit ile üretmemenizi sağlar. 
 */

Sales salesPDFReport = new Sales() { ReportFormat = new Pdf() };
Sales salesExcelrpt = new Sales() { ReportFormat = new Excel() };

