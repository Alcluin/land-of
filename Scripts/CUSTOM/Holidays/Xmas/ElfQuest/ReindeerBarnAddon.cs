
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ReindeerBarnAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {194, 5, 3, 24}, {194, 5, 2, 24}, {194, 5, -1, 24}// 1	2	3	
			, {194, 5, 5, 24}, {194, 5, 6, 24}, {194, 5, 7, 24}// 4	5	6	
			, {193, 5, 7, 24}, {183, 2, 7, 27}, {183, 1, 7, 27}// 7	8	9	
			, {183, 0, 7, 27}, {183, -2, 7, 27}, {183, -1, 7, 27}// 10	11	12	
			, {193, 3, 7, 24}, {193, 4, 7, 24}, {193, 2, 7, 24}// 13	14	15	
			, {193, 1, 7, 24}, {193, 0, 7, 24}, {193, -1, 7, 24}// 16	17	18	
			, {193, -2, 7, 24}, {1486, -1, 2, 77}, {1486, 0, 2, 77}// 19	26	27	
			, {1486, 1, 2, 77}, {8566, -1, 1, 74}, {8566, 0, 1, 74}// 28	29	30	
			, {8566, 1, 1, 74}, {8562, -1, 3, 74}, {8562, 0, 3, 74}// 31	32	33	
			, {8562, 1, 3, 74}, {8564, -1, 7, 44}, {8564, -1, 6, 44}// 34	50	51	
			, {8564, -1, 5, 44}, {8564, -1, 4, 44}, {8564, -1, 3, 44}// 52	53	54	
			, {8564, -1, 2, 44}, {8564, -1, 1, 44}, {8564, -1, 0, 44}// 55	56	57	
			, {8564, -1, -1, 44}, {8564, -1, 8, 44}, {8560, 0, 7, 44}// 58	59	60	
			, {8560, 0, 6, 44}, {8560, 0, 5, 44}, {8560, 0, 4, 44}// 61	62	63	
			, {8560, 0, 3, 44}, {8560, 0, 2, 44}, {8560, 0, 1, 44}// 64	65	66	
			, {8560, 0, 0, 44}, {8560, 0, -1, 44}, {8560, 0, 8, 44}// 67	68	69	
			, {8560, 1, 7, 41}, {8560, 1, 6, 41}, {8560, 1, 5, 41}// 70	71	72	
			, {8560, 1, 4, 41}, {8560, 1, 3, 41}, {8560, 1, 2, 41}// 73	74	75	
			, {8560, 1, 1, 41}, {8560, 1, 0, 41}, {8560, 1, -1, 41}// 76	77	78	
			, {8560, 1, 8, 41}, {8564, -2, 7, 41}, {8564, -2, 6, 41}// 79	80	81	
			, {8564, -2, 5, 41}, {8564, -2, 4, 41}, {8564, -2, 3, 41}// 82	83	84	
			, {8564, -2, 2, 41}, {8564, -2, 1, 41}, {8564, -2, 0, 41}// 85	86	87	
			, {8564, -2, -1, 41}, {8564, -2, 8, 41}, {8560, 2, 7, 38}// 88	89	90	
			, {8560, 2, 6, 38}, {8560, 2, 5, 38}, {8560, 2, 4, 38}// 91	92	93	
			, {8560, 2, 3, 38}, {8560, 2, 2, 38}, {8560, 2, 1, 38}// 94	95	96	
			, {8560, 2, 0, 38}, {8560, 2, -1, 38}, {8560, 2, 8, 38}// 97	98	99	
			, {8560, 3, 7, 35}, {8560, 3, 6, 35}, {8560, 3, 5, 35}// 100	101	102	
			, {8560, 3, 4, 35}, {8560, 3, 3, 35}, {8560, 3, 2, 35}// 103	104	105	
			, {8560, 3, 1, 35}, {8560, 3, 0, 35}, {8560, 3, -1, 35}// 106	107	108	
			, {8560, 3, 8, 35}, {8560, 4, 7, 32}, {8560, 4, 6, 32}// 109	110	111	
			, {8560, 4, 5, 32}, {8560, 4, 4, 32}, {8560, 4, 3, 32}// 112	113	114	
			, {8560, 4, 2, 32}, {8560, 4, 1, 32}, {8560, 4, 0, 32}// 115	116	117	
			, {8560, 4, -1, 32}, {8560, 4, 8, 32}, {8560, 5, 7, 29}// 118	119	120	
			, {8560, 5, 6, 29}, {8560, 5, 5, 29}, {8560, 5, 4, 29}// 121	122	123	
			, {8560, 5, 3, 29}, {8560, 5, 2, 29}, {8560, 5, 1, 29}// 124	125	126	
			, {8560, 5, 0, 29}, {8560, 5, -1, 29}, {8560, 5, 8, 29}// 127	128	129	
			, {8560, 6, 7, 26}, {8560, 6, 6, 26}, {8560, 6, 5, 26}// 130	131	132	
			, {8560, 6, 4, 26}, {8560, 6, 3, 26}, {8560, 6, 2, 26}// 133	134	135	
			, {8560, 6, 1, 26}, {8560, 6, 0, 26}, {8560, 6, -1, 26}// 136	137	138	
			, {8560, 6, 8, 26}, {2902, 1, 3, 4}, {3893, -1, 2, 4}// 139	140	141	
			, {3893, 2, 0, 4}, {40475, 7, 5, 6}, {8668, 5, 3, 4}// 142	148	149	
			, {19466, 3, 5, 10}, {1824, 6, 2, 0}, {1824, 6, -1, 0}// 156	158	159	
			, {2170, 6, 0, 0}, {2170, 6, 1, 0}, {4978, 2, 5, 10}// 160	161	163	
			, {4976, 2, 4, 10}, {8659, 1, 8, 14}, {8658, 5, 4, 14}// 164	177	178	
			, {8665, 4, 7, 4}, {8665, 3, 7, 4}, {8665, -1, 7, 4}// 179	180	181	
			, {8668, 5, 6, 4}, {8659, 5, 4, 4}, {8658, 1, 7, 4}// 182	188	189	
			, {174, 5, 7, 4}, {1993, 5, 6, 3}, {1993, 5, 5, 3}// 190	191	192	
			, {1993, 5, 4, 3}, {1993, 5, 3, 3}, {1993, 5, 2, 3}// 193	194	195	
			, {1993, 5, 1, 3}, {1993, 5, 0, 3}, {1993, 5, -1, 3}// 196	197	198	
			, {1993, 4, 7, 3}, {1993, 4, 6, 3}, {1993, 4, 5, 3}// 199	200	201	
			, {1993, 4, 4, 3}, {1993, 4, 3, 3}, {1993, 4, 2, 3}// 202	203	204	
			, {1993, 4, 1, 3}, {1993, 4, 0, 3}, {1993, 4, -1, 3}// 205	206	207	
			, {1993, 3, 7, 3}, {1993, 3, 6, 3}, {1993, 3, 5, 3}// 208	209	210	
			, {1993, 3, 4, 3}, {1993, 3, 3, 3}, {1993, 3, 2, 3}// 211	212	213	
			, {1993, 3, 1, 3}, {1993, 3, 0, 3}, {1993, 3, -1, 3}// 214	215	216	
			, {1993, 2, 7, 3}, {1993, 2, 6, 3}, {1993, 2, 5, 3}// 217	218	219	
			, {1993, 2, 4, 3}, {1993, 2, 3, 3}, {1993, 2, 2, 3}// 220	221	222	
			, {1993, 2, 1, 3}, {1993, 2, 0, 3}, {1993, 2, -1, 3}// 223	224	225	
			, {1993, 1, 7, 3}, {1993, 1, 6, 3}, {1993, 1, 5, 3}// 226	227	228	
			, {1993, 1, 4, 3}, {1993, 1, 3, 3}, {1993, 1, 2, 3}// 229	230	231	
			, {1993, 1, 1, 3}, {1993, 1, 0, 3}, {1993, 1, -1, 3}// 232	233	234	
			, {1993, 0, 7, 3}, {1993, 0, 6, 3}, {1993, 0, 5, 3}// 235	236	237	
			, {1993, 0, 4, 3}, {1993, 0, 3, 3}, {1993, 0, 2, 3}// 238	239	240	
			, {1993, 0, 1, 3}, {1993, 0, 0, 3}, {1993, 0, -1, 3}// 241	242	243	
			, {1993, -1, 7, 3}, {1993, -1, 6, 3}, {1993, -1, 5, 3}// 244	245	246	
			, {1993, -1, 4, 3}, {1993, -1, 3, 3}, {1993, -1, 2, 3}// 247	248	249	
			, {1993, -1, 1, 3}, {1993, -1, 0, 3}, {1993, -1, -1, 3}// 250	251	252	
			, {1993, -2, 7, 3}, {1993, -2, 6, 3}, {1993, -2, 5, 3}// 253	254	255	
			, {1993, -2, 4, 3}, {1993, -2, 3, 3}, {1993, -2, 2, 3}// 256	257	258	
			, {1993, -2, 1, 3}, {1993, -2, 0, 3}, {1993, -2, -1, 3}// 259	260	261	
			, {1993, 5, 7, 3}, {46, 5, 6, 0}, {46, 5, 5, 0}// 262	263	264	
			, {46, 5, 4, 0}, {46, 5, 3, 0}, {46, 5, 2, 0}// 265	266	267	
			, {46, 5, 1, 0}, {46, 5, 0, 0}, {46, 5, -1, 0}// 268	269	270	
			, {47, 4, 7, 0}, {47, 3, 7, 0}, {47, 2, 7, 0}// 271	272	273	
			, {47, 1, 7, 0}, {47, 0, 7, 0}, {47, -1, 7, 0}// 274	275	276	
			, {47, -2, 7, 0}, {45, 5, 7, 0}, {193, 0, -8, 24}// 277	278	279	
			, {193, -1, -8, 24}, {193, -2, -8, 24}, {193, 5, -8, 24}// 280	281	282	
			, {193, 4, -8, 24}, {193, 3, -8, 24}, {193, 2, -8, 24}// 283	284	285	
			, {194, 5, -4, 24}, {194, 5, -2, 24}, {194, 5, -6, 24}// 286	287	288	
			, {194, 5, -7, 24}, {8564, -1, -2, 44}, {8564, -1, -3, 44}// 289	290	291	
			, {8564, -1, -4, 44}, {8564, -1, -5, 44}, {8564, -1, -6, 44}// 292	293	294	
			, {8564, -1, -7, 44}, {8560, 0, -2, 44}, {8560, 0, -3, 44}// 295	296	297	
			, {8560, 0, -4, 44}, {8560, 0, -5, 44}, {8560, 0, -6, 44}// 298	299	300	
			, {8560, 0, -7, 44}, {8560, 1, -2, 41}, {8560, 1, -3, 41}// 301	302	303	
			, {8560, 1, -4, 41}, {8560, 1, -5, 41}, {8560, 1, -6, 41}// 304	305	306	
			, {8560, 1, -7, 41}, {8564, -2, -2, 41}, {8564, -2, -3, 41}// 307	308	309	
			, {8564, -2, -4, 41}, {8564, -2, -5, 41}, {8564, -2, -6, 41}// 310	311	312	
			, {8564, -2, -7, 41}, {8560, 2, -2, 38}, {8560, 2, -3, 38}// 313	314	315	
			, {8560, 2, -4, 38}, {8560, 2, -5, 38}, {8560, 2, -6, 38}// 316	317	318	
			, {8560, 2, -7, 38}, {8560, 3, -2, 35}, {8560, 3, -3, 35}// 319	320	321	
			, {8560, 3, -4, 35}, {8560, 3, -5, 35}, {8560, 3, -6, 35}// 322	323	324	
			, {8560, 3, -7, 35}, {8560, 4, -2, 32}, {8560, 4, -3, 32}// 325	326	327	
			, {8560, 4, -4, 32}, {8560, 4, -5, 32}, {8560, 4, -6, 32}// 328	329	330	
			, {8560, 4, -7, 32}, {8560, 5, -2, 29}, {8560, 5, -3, 29}// 331	332	333	
			, {8560, 5, -4, 29}, {8560, 5, -5, 29}, {8560, 5, -6, 29}// 334	335	336	
			, {8560, 5, -7, 29}, {8560, 6, -2, 26}, {8560, 6, -3, 26}// 337	338	339	
			, {8560, 6, -4, 26}, {8560, 6, -5, 26}, {8560, 6, -6, 26}// 340	341	342	
			, {8560, 6, -7, 26}, {2884, 3, -7, 4}, {2883, 2, -7, 4}// 343	344	345	
			, {3894, 0, -7, 4}, {3893, 2, -5, 4}, {3892, 3, -4, 4}// 346	347	348	
			, {3892, 0, -6, 4}, {40383, 0, -2, 3}, {40388, 7, -4, 6}// 349	350	354	
			, {1824, 6, -2, 0}, {8658, 5, -5, 14}, {8659, 5, -5, 4}// 361	362	363	
			, {8659, 1, -8, 13}, {8658, 6, -3, 14}, {8665, 3, -8, 3}// 378	379	380	
			, {8665, 4, -8, 3}, {8665, -1, -8, 3}, {8668, 5, -2, 4}// 381	382	383	
			, {8668, 5, -6, 4}, {8659, 5, -3, 4}, {8658, 1, -8, 3}// 384	389	390	
			, {8668, 5, -7, 4}, {8665, 5, -8, 3}, {1993, 5, -2, 3}// 391	392	393	
			, {1993, 5, -3, 3}, {1993, 5, -4, 3}, {1993, 5, -5, 3}// 394	395	396	
			, {1993, 5, -6, 3}, {1993, 5, -7, 3}, {1993, 4, -2, 3}// 397	398	399	
			, {1993, 4, -3, 3}, {1993, 4, -4, 3}, {1993, 4, -5, 3}// 400	401	402	
			, {1993, 4, -6, 3}, {1993, 4, -7, 3}, {1993, 3, -2, 3}// 403	404	405	
			, {1993, 3, -3, 3}, {1993, 3, -4, 3}, {1993, 3, -5, 3}// 406	407	408	
			, {1993, 3, -6, 3}, {1993, 3, -7, 3}, {1993, 2, -2, 3}// 409	410	411	
			, {1993, 2, -3, 3}, {1993, 2, -4, 3}, {1993, 2, -5, 3}// 412	413	414	
			, {1993, 2, -6, 3}, {1993, 2, -7, 3}, {1993, 1, -2, 3}// 415	416	417	
			, {1993, 1, -3, 3}, {1993, 1, -4, 3}, {1993, 1, -5, 3}// 418	419	420	
			, {1993, 1, -6, 3}, {1993, 1, -7, 3}, {1993, 0, -2, 3}// 421	422	423	
			, {1993, 0, -3, 3}, {1993, 0, -4, 3}, {1993, 0, -5, 3}// 424	425	426	
			, {1993, 0, -6, 3}, {1993, 0, -7, 3}, {1993, -1, -2, 3}// 427	428	429	
			, {1993, -1, -3, 3}, {1993, -1, -4, 3}, {1993, -1, -5, 3}// 430	431	432	
			, {1993, -1, -6, 3}, {1993, -1, -7, 3}, {1993, -2, -2, 3}// 433	434	435	
			, {1993, -2, -3, 3}, {1993, -2, -4, 3}, {1993, -2, -5, 3}// 436	437	438	
			, {1993, -2, -6, 3}, {1993, -2, -7, 3}, {47, 0, -8, 0}// 439	440	441	
			, {47, -1, -8, 0}, {47, -2, -8, 0}, {47, 5, -8, 0}// 442	443	444	
			, {47, 4, -8, 0}, {47, 3, -8, 0}, {47, 2, -8, 0}// 445	446	447	
			, {47, 1, -8, 0}, {46, 5, -5, 0}, {46, 5, -6, 0}// 448	449	450	
			, {46, 5, -7, 0}, {46, 5, -2, 0}, {46, 5, -3, 0}// 451	452	453	
			, {46, 5, -4, 0}, {8564, -4, 0, 32}, {194, -8, 1, 24}// 454	455	456	
			, {194, -8, 2, 24}, {194, -8, 4, 24}, {194, -8, 5, 24}// 457	458	459	
			, {194, -8, 6, 24}, {194, -8, 7, 24}, {193, -7, 7, 24}// 460	461	462	
			, {183, -4, 7, 27}, {183, -5, 7, 27}, {183, -3, 7, 27}// 463	464	465	
			, {193, -6, 7, 24}, {193, -5, 7, 24}, {193, -4, 7, 24}// 466	467	468	
			, {193, -3, 7, 24}, {8564, -4, 0, 32}, {8564, -3, 0, 44}// 469	470	471	
			, {8564, -3, 7, 38}, {8564, -3, 6, 38}, {8564, -3, 5, 38}// 472	473	474	
			, {8564, -3, 4, 38}, {8564, -3, 3, 38}, {8564, -3, 2, 38}// 475	476	477	
			, {8564, -3, 1, 38}, {8564, -3, 0, 38}, {8564, -3, -1, 38}// 478	479	480	
			, {8564, -3, 8, 38}, {8564, -4, 7, 35}, {8564, -4, 6, 35}// 481	482	483	
			, {8564, -4, 5, 35}, {8564, -4, 4, 35}, {8564, -4, 3, 35}// 484	485	486	
			, {8564, -4, 2, 35}, {8564, -4, 1, 35}, {8564, -4, 0, 41}// 487	488	489	
			, {8564, -3, -1, 38}, {8564, -4, 8, 35}, {8564, -5, 7, 32}// 490	491	492	
			, {8564, -5, 6, 32}, {8564, -5, 5, 32}, {8564, -5, 4, 32}// 493	494	495	
			, {8564, -5, 3, 32}, {8564, -5, 2, 32}, {8564, -5, 1, 32}// 496	497	498	
			, {8564, -5, 0, 32}, {8564, -5, -1, 32}, {8564, -5, 8, 32}// 499	500	501	
			, {8564, -6, 7, 29}, {8564, -6, 6, 29}, {8564, -6, 5, 29}// 502	503	504	
			, {8564, -6, 4, 29}, {8564, -6, 3, 29}, {8564, -6, 2, 29}// 505	506	507	
			, {8564, -6, 1, 29}, {8564, -6, 0, 29}, {8564, -6, -1, 29}// 508	509	510	
			, {8564, -6, 8, 29}, {8564, -7, 7, 26}, {8564, -7, 6, 26}// 511	512	513	
			, {8564, -7, 5, 26}, {8564, -7, 4, 26}, {8564, -7, 3, 26}// 514	515	516	
			, {8564, -7, 2, 26}, {8564, -7, 1, 26}, {8564, -7, 0, 26}// 517	518	519	
			, {8564, -7, -1, 26}, {8564, -7, 8, 26}, {2882, -7, 5, 4}// 520	521	522	
			, {2881, -7, 4, 4}, {3894, -7, -1, 4}, {3894, -7, 1, 4}// 523	524	525	
			, {3893, -5, 3, 4}, {3892, -6, -1, 4}, {3892, -5, 2, 4}// 526	527	528	
			, {3892, -5, 4, 4}, {8659, -3, 8, 14}, {8658, -8, 0, 14}// 529	549	550	
			, {8658, -8, 3, 13}, {8660, -8, -1, 4}, {8660, -8, 0, 4}// 551	552	553	
			, {8665, -6, 7, 4}, {8665, -5, 7, 4}, {8668, -8, 1, 4}// 554	555	556	
			, {8668, -8, 5, 4}, {1993, -7, 5, 3}, {8668, -8, 6, 4}// 557	558	559	
			, {8659, -8, 3, 3}, {8658, -3, 7, 4}, {8668, -8, 7, 4}// 563	564	565	
			, {8665, -7, 7, 4}, {1993, -3, 7, 3}, {1993, -3, 6, 3}// 566	567	568	
			, {1993, -3, 5, 3}, {1993, -3, 4, 3}, {1993, -3, 3, 3}// 569	570	571	
			, {1993, -3, 2, 3}, {1993, -3, 1, 3}, {1993, -3, 0, 3}// 572	573	574	
			, {1993, -3, -1, 3}, {1993, -4, 7, 3}, {1993, -4, 6, 3}// 575	576	577	
			, {1993, -4, 5, 3}, {1993, -4, 4, 3}, {1993, -4, 3, 3}// 578	579	580	
			, {1993, -4, 2, 3}, {1993, -4, 1, 3}, {1993, -4, 0, 3}// 581	582	583	
			, {1993, -4, -1, 3}, {1993, -5, 7, 3}, {1993, -5, 6, 3}// 584	585	586	
			, {1993, -5, 5, 3}, {1993, -5, 4, 3}, {1993, -5, 3, 3}// 587	588	589	
			, {1993, -5, 2, 3}, {1993, -5, 1, 3}, {1993, -5, 0, 3}// 590	591	592	
			, {1993, -5, -1, 3}, {1993, -6, 7, 3}, {1993, -6, 6, 3}// 593	594	595	
			, {1993, -6, 5, 3}, {1993, -6, 4, 3}, {1993, -6, 3, 3}// 596	597	598	
			, {1993, -6, 2, 3}, {1993, -6, 1, 3}, {1993, -6, 0, 3}// 599	600	601	
			, {1993, -6, -1, 3}, {1993, -7, 7, 3}, {1993, -7, 6, 3}// 602	603	604	
			, {1993, -7, 6, 3}, {1993, -7, 4, 3}, {1993, -7, 3, 3}// 605	606	607	
			, {1993, -7, 2, 3}, {1993, -7, 1, 3}, {1993, -7, 0, 3}// 608	609	610	
			, {1993, -7, -1, 3}, {46, -8, 2, 0}, {46, -8, 1, 0}// 611	612	613	
			, {46, -8, 0, 0}, {46, -8, -1, 0}, {46, -8, 7, 0}// 614	615	616	
			, {46, -8, 6, 0}, {46, -8, 5, 0}, {46, -8, 4, 0}// 617	618	619	
			, {46, -8, 3, 0}, {47, -5, 7, 0}, {47, -6, 7, 0}// 620	621	622	
			, {47, -7, 7, 0}, {47, -3, 7, 0}, {47, -4, 7, 0}// 623	624	625	
			, {193, -4, -8, 24}, {193, -5, -8, 24}, {193, -6, -8, 24}// 626	627	628	
			, {193, -7, -8, 24}, {194, -8, -6, 24}, {194, -8, -7, 24}// 629	630	631	
			, {194, -8, -5, 24}, {194, -8, -3, 24}, {194, -8, -2, 24}// 632	633	634	
			, {8564, -3, -2, 38}, {8564, -3, -3, 38}, {8564, -3, -4, 38}// 635	636	637	
			, {8564, -3, -5, 38}, {8564, -3, -6, 38}, {8564, -3, -7, 38}// 638	639	640	
			, {8564, -4, -2, 35}, {8564, -4, -3, 35}, {8564, -4, -4, 35}// 641	642	643	
			, {8564, -4, -5, 35}, {8564, -4, -6, 35}, {8564, -4, -7, 35}// 644	645	646	
			, {8564, -5, -2, 32}, {8564, -5, -3, 32}, {8564, -5, -4, 32}// 647	648	649	
			, {8564, -5, -5, 32}, {8564, -5, -6, 32}, {8564, -5, -7, 32}// 650	651	652	
			, {8564, -6, -2, 29}, {8564, -6, -3, 29}, {8564, -6, -4, 29}// 653	654	655	
			, {8564, -6, -5, 29}, {8564, -6, -6, 29}, {8564, -6, -7, 29}// 656	657	658	
			, {3894, -6, -7, 4}, {3894, -7, -7, 4}, {8564, -7, -2, 26}// 659	660	661	
			, {8564, -7, -3, 26}, {8564, -7, -4, 26}, {8564, -7, -5, 26}// 662	663	664	
			, {8564, -7, -6, 26}, {8564, -7, -7, 26}, {2882, -7, -2, 4}// 665	666	667	
			, {2881, -7, -3, 4}, {3893, -5, -3, 4}, {3893, -5, -2, 4}// 668	669	670	
			, {3892, -4, -4, 4}, {8659, -3, -8, 13}, {8658, -8, -4, 13}// 671	680	681	
			, {8658, -8, -2, 14}, {8665, -5, -8, 3}, {8665, -6, -8, 3}// 682	683	684	
			, {8668, -8, -2, 4}, {8668, -8, -6, 4}, {8659, -8, -4, 3}// 685	686	690	
			, {8658, -3, -8, 3}, {8668, -8, -7, 4}, {8665, -7, -8, 3}// 691	692	693	
			, {1993, -3, -2, 3}, {1993, -3, -3, 3}, {1993, -3, -4, 3}// 694	695	696	
			, {1993, -3, -5, 3}, {1993, -3, -6, 3}, {1993, -3, -7, 3}// 697	698	699	
			, {1993, -4, -2, 3}, {1993, -4, -3, 3}, {1993, -4, -4, 3}// 700	701	702	
			, {1993, -4, -5, 3}, {1993, -4, -6, 3}, {1993, -4, -7, 3}// 703	704	705	
			, {1993, -5, -2, 3}, {1993, -5, -3, 3}, {1993, -5, -4, 3}// 706	707	708	
			, {1993, -5, -5, 3}, {1993, -5, -6, 3}, {1993, -5, -7, 3}// 709	710	711	
			, {1993, -6, -2, 3}, {1993, -6, -3, 3}, {1993, -6, -4, 3}// 712	713	714	
			, {1993, -6, -5, 3}, {1993, -6, -6, 3}, {1993, -6, -7, 3}// 715	716	717	
			, {1993, -7, -2, 3}, {1993, -7, -3, 3}, {1993, -7, -4, 3}// 718	719	720	
			, {1993, -7, -5, 3}, {1993, -7, -6, 3}, {1993, -7, -7, 3}// 721	722	723	
			, {46, -8, -7, 0}, {47, -4, -8, 0}, {47, -5, -8, 0}// 724	725	726	
			, {47, -6, -8, 0}, {47, -7, -8, 0}, {47, -3, -8, 0}// 727	728	729	
			, {46, -8, -2, 0}, {46, -8, -3, 0}, {46, -8, -4, 0}// 730	731	732	
			, {46, -8, -5, 0}, {46, -8, -6, 0}// 733	734	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ReindeerBarnAddonDeed();
			}
		}

		[ Constructable ]
		public ReindeerBarnAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 14951, -1, 3, 61, 0, -1, "Reindeer", 1);// 20
			AddComplexComponent( (BaseAddon) this, 14952, 1, 1, 61, 0, -1, "Reindeer", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1305, 0, 1, 61, 1003, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1305, 0, 2, 61, 1003, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1305, -1, 2, 61, 1003, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1305, -1, 1, 44, 1003, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 192, -2, 0, 67, 1368, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 192, -2, 0, 62, 1368, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 192, -2, 2, 67, 1368, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 192, -2, 2, 62, 1368, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 8659, -2, 2, 52, 32, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 192, 0, 0, 67, 1368, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 192, 0, 0, 62, 1368, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 192, 0, 2, 68, 1368, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 192, 0, 2, 63, 1368, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 8659, 0, 1, 52, 32, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 8657, 0, 0, 52, 32, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 8657, -1, 0, 52, 32, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 8657, -1, 2, 52, 32, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 8659, -2, 1, 52, 32, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 182, 0, 2, 53, 32, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 40386, 8, -1, 4, 0, -1, "Bow", 1);// 143
			AddComplexComponent( (BaseAddon) this, 40386, 8, 3, 4, 0, -1, "Bow", 1);// 144
			AddComplexComponent( (BaseAddon) this, 40384, -2, 1, 4, 0, -1, "Christmas Bells", 1);// 145
			AddComplexComponent( (BaseAddon) this, 40960, 7, 6, 1, 0, -1, "Christmas Garland", 1);// 146
			AddComplexComponent( (BaseAddon) this, 40960, 7, 5, 1, 0, -1, "Christmas Garland", 1);// 147
			AddComplexComponent( (BaseAddon) this, 2145, 6, 4, 0, 32, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 2145, 6, 5, 0, 32, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 2141, 6, 3, 0, 32, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 2140, 6, 6, 0, 32, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 2848, 6, 7, 0, 0, 1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 14951, 6, -1, 5, 0, -1, "Reindeer", 1);// 155
			AddComplexComponent( (BaseAddon) this, 14947, 6, 2, 4, 0, -1, "Reindeer", 1);// 157
			AddComplexComponent( (BaseAddon) this, 187, 5, -1, 4, 0, 1, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 4980, 1, 5, 10, 1260, -1, "Reindeer Halter", 1);// 165
			AddComplexComponent( (BaseAddon) this, 4980, 1, 4, 10, 1260, -1, "Reindeer Halter", 1);// 166
			AddComplexComponent( (BaseAddon) this, 4980, 0, 4, 10, 1260, -1, "Reindeer Halter", 1);// 167
			AddComplexComponent( (BaseAddon) this, 4980, 0, 5, 10, 1260, -1, "Reindeer Halter", 1);// 168
			AddComplexComponent( (BaseAddon) this, 2957, 0, 4, 4, 1368, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 2957, 1, 4, 4, 1368, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 2957, 2, 4, 4, 1368, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 2957, 2, 5, 4, 1368, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 2957, 1, 5, 4, 1368, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 2956, 0, 5, 4, 1368, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 2954, 3, 4, 4, 1368, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 2955, 3, 5, 4, 1368, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 188, 2, 7, 4, 0, 1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 188, 0, 7, 4, 0, 1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 188, -2, 7, 4, 0, 1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 187, 5, 5, 4, 0, 1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 187, 5, 2, 4, 0, 1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 40384, -2, -5, 3, 0, -1, "Christmas Bells", 1);// 351
			AddComplexComponent( (BaseAddon) this, 40960, 7, -3, 1, 0, -1, "Christmas Garland", 1);// 352
			AddComplexComponent( (BaseAddon) this, 40960, 7, -5, 1, 0, -1, "Christmas Garland", 1);// 353
			AddComplexComponent( (BaseAddon) this, 2145, 6, -4, 0, 32, -1, "", 1);// 355
			AddComplexComponent( (BaseAddon) this, 2145, 6, -5, 0, 32, -1, "", 1);// 356
			AddComplexComponent( (BaseAddon) this, 2145, 6, -6, 0, 32, -1, "", 1);// 357
			AddComplexComponent( (BaseAddon) this, 2140, 6, -3, 0, 32, -1, "", 1);// 358
			AddComplexComponent( (BaseAddon) this, 2141, 6, -7, 0, 32, -1, "", 1);// 359
			AddComplexComponent( (BaseAddon) this, 2848, 6, -8, 0, 0, 1, "", 1);// 360
			AddComplexComponent( (BaseAddon) this, 2145, 4, -7, 4, 32, -1, "", 1);// 364
			AddComplexComponent( (BaseAddon) this, 2145, 4, -6, 4, 32, -1, "", 1);// 365
			AddComplexComponent( (BaseAddon) this, 2145, 4, -5, 4, 32, -1, "", 1);// 366
			AddComplexComponent( (BaseAddon) this, 2145, 4, -3, 4, 32, -1, "", 1);// 367
			AddComplexComponent( (BaseAddon) this, 2145, 4, -4, 4, 32, -1, "", 1);// 368
			AddComplexComponent( (BaseAddon) this, 2145, -1, -4, 4, 32, -1, "", 1);// 369
			AddComplexComponent( (BaseAddon) this, 2142, -1, -3, 4, 32, -1, "", 1);// 370
			AddComplexComponent( (BaseAddon) this, 2144, 0, -3, 4, 32, -1, "", 1);// 371
			AddComplexComponent( (BaseAddon) this, 2144, 1, -3, 4, 32, -1, "", 1);// 372
			AddComplexComponent( (BaseAddon) this, 2144, 3, -3, 4, 32, -1, "", 1);// 373
			AddComplexComponent( (BaseAddon) this, 2141, 4, -3, 4, 32, -1, "", 1);// 374
			AddComplexComponent( (BaseAddon) this, 2145, -1, -5, 4, 32, -1, "", 1);// 375
			AddComplexComponent( (BaseAddon) this, 2145, -1, -6, 4, 32, -1, "", 1);// 376
			AddComplexComponent( (BaseAddon) this, 2145, -1, -7, 4, 32, -1, "", 1);// 377
			AddComplexComponent( (BaseAddon) this, 188, 2, -8, 3, 0, 1, "", 1);// 385
			AddComplexComponent( (BaseAddon) this, 188, 0, -8, 3, 0, 1, "", 1);// 386
			AddComplexComponent( (BaseAddon) this, 188, -2, -8, 3, 0, 1, "", 1);// 387
			AddComplexComponent( (BaseAddon) this, 187, 5, -4, 4, 0, 1, "", 1);// 388
			AddComplexComponent( (BaseAddon) this, 2145, -3, -1, 4, 32, -1, "", 1);// 530
			AddComplexComponent( (BaseAddon) this, 2145, -3, 0, 4, 32, -1, "", 1);// 531
			AddComplexComponent( (BaseAddon) this, 2143, -3, 4, 4, 32, -1, "", 1);// 532
			AddComplexComponent( (BaseAddon) this, 2143, -7, 0, 4, 32, -1, "", 1);// 533
			AddComplexComponent( (BaseAddon) this, 2143, -5, 0, 4, 32, -1, "", 1);// 534
			AddComplexComponent( (BaseAddon) this, 2145, -3, 1, 4, 32, -1, "", 1);// 535
			AddComplexComponent( (BaseAddon) this, 2141, -3, 0, 4, 32, -1, "", 1);// 536
			AddComplexComponent( (BaseAddon) this, 2145, -3, 4, 4, 32, -1, "", 1);// 537
			AddComplexComponent( (BaseAddon) this, 2145, -3, 5, 4, 32, -1, "", 1);// 538
			AddComplexComponent( (BaseAddon) this, 2142, -3, 2, 4, 32, -1, "", 1);// 539
			AddComplexComponent( (BaseAddon) this, 2144, -4, 0, 4, 32, -1, "", 1);// 540
			AddComplexComponent( (BaseAddon) this, 2144, -5, 0, 4, 32, -1, "", 1);// 541
			AddComplexComponent( (BaseAddon) this, 2144, -6, 0, 4, 32, -1, "", 1);// 542
			AddComplexComponent( (BaseAddon) this, 2144, -7, 0, 4, 32, -1, "", 1);// 543
			AddComplexComponent( (BaseAddon) this, 2144, -7, 6, 4, 32, -1, "", 1);// 544
			AddComplexComponent( (BaseAddon) this, 2144, -6, 6, 4, 32, -1, "", 1);// 545
			AddComplexComponent( (BaseAddon) this, 2144, -5, 6, 4, 32, -1, "", 1);// 546
			AddComplexComponent( (BaseAddon) this, 2144, -4, 6, 4, 32, -1, "", 1);// 547
			AddComplexComponent( (BaseAddon) this, 2140, -3, 6, 4, 32, -1, "", 1);// 548
			AddComplexComponent( (BaseAddon) this, 188, -4, 7, 4, 0, 1, "", 1);// 560
			AddComplexComponent( (BaseAddon) this, 187, -8, 2, 4, 0, 1, "", 1);// 561
			AddComplexComponent( (BaseAddon) this, 187, -8, 4, 4, 0, 1, "", 1);// 562
			AddComplexComponent( (BaseAddon) this, 2145, -3, -4, 4, 32, -1, "", 1);// 672
			AddComplexComponent( (BaseAddon) this, 2145, -3, -5, 4, 32, -1, "", 1);// 673
			AddComplexComponent( (BaseAddon) this, 2142, -3, -3, 4, 32, -1, "", 1);// 674
			AddComplexComponent( (BaseAddon) this, 2141, -3, -6, 4, 32, -1, "", 1);// 675
			AddComplexComponent( (BaseAddon) this, 2144, -4, -6, 4, 32, -1, "", 1);// 676
			AddComplexComponent( (BaseAddon) this, 2144, -5, -6, 4, 32, -1, "", 1);// 677
			AddComplexComponent( (BaseAddon) this, 2144, -6, -6, 4, 32, -1, "", 1);// 678
			AddComplexComponent( (BaseAddon) this, 2144, -7, -6, 4, 32, -1, "", 1);// 679
			AddComplexComponent( (BaseAddon) this, 188, -4, -8, 3, 0, 1, "", 1);// 687
			AddComplexComponent( (BaseAddon) this, 187, -8, -3, 4, 0, 1, "", 1);// 688
			AddComplexComponent( (BaseAddon) this, 187, -8, -5, 4, 0, 1, "", 1);// 689

		}

		public ReindeerBarnAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class ReindeerBarnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ReindeerBarnAddon();
			}
		}

		[Constructable]
		public ReindeerBarnAddonDeed()
		{
			Name = "ReindeerBarn";
		}

		public ReindeerBarnAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}