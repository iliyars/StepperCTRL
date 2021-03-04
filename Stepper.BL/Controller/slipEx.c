/* SLIP special character codes
    */
   #define END             0300    /* indicates end of packet */
   #define ESC             0333    /* indicates byte stuffing */
   #define ESC_END         0334    /* ESC ESC_END means END data byte */
   #define ESC_ESC         0335    /* ESC ESC_ESC means ESC data byte */

   /* SEND_PACKET: sends a packet of length "len", starting at
    * location "p".
    */
   void send_packet(p, len)
           char *p;
           int len; {

     /* send an initial END character to flush out any data that may
      * have accumulated in the receiver due to line noise
      */
        send_char(END);

     /* for each byte in the packet, send the appropriate character
      * sequence
      */
           while(len--) {
                   switch(*p) {
                   /* if it's the same code as an END character, we send a
                    * special two character code so as not to make the
                    * receiver think we sent an END
                    */
                   case END:
                           send_char(ESC);
                           send_char(ESC_END);
                           break;

                   /* if it's the same code as an ESC character,
                    * we send a special two character code so as not
                    * to make the receiver think we sent an ESC
                    */
                   case ESC:
                           send_char(ESC);
                           send_char(ESC_ESC);
                           break;
