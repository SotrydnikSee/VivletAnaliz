XY = [
    249 279
248.9993 279
248.7257 278.3351
247.6108 276.392
247.2773 275.6343
246.7956 274.8034
246.3777 274.0131
245.3863 272.5649
244.7334 271.2113
244.7335 271.2113
244.2119 270.7076
243.6245 270.0204
243.2117 269.6773
242.3009 268.7547
241.8874 268.1673
241.2939 267.447
240.8464 267.0135
240.8443 267.0159
239.9789 265.8807
239.5687 265.4633
239.2716 265.0415
238.8613 264.5958
238.399 264.0493
237.2304 263.1776
236.6818 262.5576
235.9508 262.0226
235.2323 261.5782
234.3512 260.8349
233.106 260.0591
232.6715 259.6551
232.0132 258.9658
231.3116 258.4432
230.8232 257.9917
230.4408 257.6007
229.739 256.6964
229.4034 256.1739
229.082 255.6544
228.6369 255.1315
227.2177 253.2386
226.7915 252.5812
226.449 251.9288
226.4466 251.9294
226.0299 251.2226
224.7181 249.8195
224.2855 249.2999
223.7821 248.7118
223.2049 248.0411
222.6112 247.3755
222.2359 246.792
221.7467 246.3425
221.2817 245.5675
220.8087 245.0483
220.4858 244.5706
220.1518 244.0683
219.485 243.3794
218.9878 242.9016
218.7438 242.6698
218.3275 242.2583
217.4964 241.4622
217.2004 241.1137
217.0012 240.928
216.7899 240.6816
216.7823 240.6808
216.6533 240.5798
216.6532 240.574
216.5234 240.5745
216.3092 240.412
216.1778 240.316
216.1682 240.3369
215.9979 240.2164
215.9567 240.2034
215.792 240.0895
215.7657 239.9978
215.6998 239.8924
215.5425 239.6578
215.4589 239.4468
215.4569 239.4535
215.3674 239.2596
215.31 238.9436
215.2067 238.8002
215.0981 238.6165
214.9892 238.457
214.8461 238.3032
214.7122 238.0353
214.7054 238.0376
214.6286 237.9223
214.5462 237.7768
214.4765 237.6493
214.3687 237.398
214.235 237.1655
214.0575 236.7614
213.9379 236.5611
213.9337 236.5586
213.813 236.2365
213.7004 236.0569
213.6044 235.9321
213.498 235.7674
213.445 235.5587
213.3195 235.2629
213.1149 235.0638
213.1198 235.0267
213.0044 234.7577
212.7867 234.2915
212.5732 233.5359
212.4034 233.1636
212.202 232.5019
212.2001 232.4995
212.1316 232.3531
209.6578 230.8549
209.1983 230.2328
209.101 230.0635
208.9247 229.7295
208.7016 229.5067
208.1787 228.7647
207.9421 228.5346
207.7697 228.425
207.7686 228.4279
207.7006 228.2915
207.5366 228.2846
207.4094 228.1345
207.3141 227.9717
207.1644 227.6734
207.1407 227.5734
206.9739 227.3505
206.9102 227.29
206.7618 227.1141
206.6423 226.9218
206.5389 226.8108
206.4196 226.7224
206.3518 226.6324
206.2915 226.5392
];
Vector3 = zeros(1,51);
for i = 1:51
    Vector3(i)=sqrt((XY(i+1,1)-XY(i,1))^2 + (XY(i+1,2)-XY(i,2))^2);
end
figure;
subplot(332);
plot(Vector3'); %������ ���������
% subplot(337);
% cwt(Vector3);
%-------------------------------
%dwt(Vector3,'haar');%������������� ���������� ���������� �������-��������������.
    %�������-�����
%subplot(336);
%plot(ans);
%dwt(Vector3,'db4');%������������� ���������� ���������� �������-��������������
    %�������-������
%subplot(337);
%plot(ans);
%dwt(Vector3,'sym2');%������������� ���������� ���������� �������-��������������
%subplot(338);
%plot(ans);
%-------------------------------
subplot(333);
W1=cwt(Vector3,1:64,'haar','plot');%��������� �������-������������ ����������� �������, 
    %��������� ����������� �������-��������������
subplot(334);
W2=cwt(Vector3,1:64,'db4','plot');
subplot(335);
W3=cwt(Vector3,1:64,'sym2','plot');
%-------------------------------
XY = [
    482 300
482.5743 300.0977
483.1843 300.1895
483.8992 300.2505
484.7568 300.2027
485.65 300.1275
486.5016 300.0136
487.2301 299.8055
487.8913 299.7614
488.6452 299.6669
489.4031 299.6794
490.203 299.6967
490.9062 299.6681
491.624 299.7223
492.4972 299.9034
493.3203 299.9892
494.2402 300.1294
495.2557 300.2128
496.2749 300.1407
497.0537 300.0459
497.813 299.9853
498.6954 299.8557
499.424 299.7346
500.2252 299.6455
500.9072 299.5738
501.6237 299.6022
502.5442 299.7208
503.3687 299.8808
504.2865 300.0071
505.1805 300.1087
506.0627 300.1075
507.1511 300.0291
508.0414 300.0771
508.7489 299.8746
509.5389 299.7246
510.3386 299.6236
511.2291 299.5679
512.0694 299.615
512.7744 299.6669
513.6341 299.7646
514.3859 299.7827
515.4017 300.1073
516.3731 300.2503
517.4568 300.3564
518.4578 300.4123
519.5107 300.4119
520.5768 300.25
521.4689 300.2194
522.2836 300.0952
523.1007 300.0665
523.7551 300.003
524.5148 300.0407
525.4094 300.168
526.2158 300.1989
527.1526 300.1766
528.0502 300.3714
529.0477 300.403
530.0189 300.4331
531.0231 300.444
531.8647 300.3542
532.6666 300.2927
533.6116 300.0814
534.1445 300.1304
534.7435 300.1017
535.3904 300.1146
535.8982 300.0577
536.519 300.0384
537.1837 300.0182
537.5762 299.9426
538.0336 299.8286
538.4201 299.7218
538.8091 299.6244
538.9013 299.6057
538.9061 299.617
538.8868 299.6183
538.9053 299.619
538.9206 299.6138
538.92 299.6064
538.9307 299.609
538.9445 299.5995
538.9488 299.596
538.9538 299.5984
];
Vector4 = zeros(1,51);
for i = 1:51
    Vector4(i)=sqrt((XY(i+1,1)-XY(i,1))^2 + (XY(i+1,2)-XY(i,2))^2);
end
figure;
subplot(332);
plot(Vector4'); %������ ���������
% subplot(332);
% cwt(Vector4);
%-------------------------------
subplot(333);
R1=cwt(Vector4,1:64,'haar','plot');%��������� �������-������������ ����������� �������, 
    %��������� ����������� �������-��������������
subplot(334);
R2=cwt(Vector4,1:64,'db4','plot');
subplot(335);
R3=cwt(Vector4,1:64,'sym2','plot');
%-------------------------------
A=abs(W3-R3);
Max=max(A);
Min=min(A);