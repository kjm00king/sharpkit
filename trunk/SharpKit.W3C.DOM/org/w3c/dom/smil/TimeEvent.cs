//AutoGenerated

namespace org.w3c.dom.smil
{

    using Event = org.w3c.dom.events.Event;
    using AbstractView = org.w3c.dom.views.AbstractView;

    public interface TimeEvent : org.w3c.dom.events.Event
    {
        // TimeEvent
        AbstractView view {get;}
        int detail {get;}
        void initTimeEvent(string typeArg, AbstractView viewArg, int detailArg);
    }

}